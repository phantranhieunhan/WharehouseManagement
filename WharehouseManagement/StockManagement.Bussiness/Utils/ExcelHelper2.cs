using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using StockManagement.Business;
using StockManagement.Data;

namespace HR.Business
{
    public class ExcelExtensionHelper2
    {
        public class AttributiesOfXML
        {
            public string sPosition = "";
            public string pIsSort = "";
            public string pColName = "";
            public string pAlign = "";
            public string pFormat = "";
            public string pValue = "";
            public string pValueName = "";
            public string pTitle = "";
            public int pPosition;
            public string pIsSum = "";

            public AttributiesOfXML(XmlNode nCol)
            {
                this.pIsSort = nCol?.Attributes?["IsSort"]?.InnerText ?? "0";
                this.pColName = nCol?.Attributes?["Name"]?.InnerText ?? "";
                this.pAlign = nCol?.Attributes?["Align"]?.InnerText ?? "Left";//(Left, Center, Right). Nếu ko tồn tại thì mặc định "Left"
                this.pFormat = nCol?.Attributes?["Format"]?.InnerText;
                this.pValue = nCol?.Attributes?["Value"]?.InnerText;
                this.pValueName = nCol?.Attributes?["ValueName"]?.InnerText ?? "";
                this.pTitle = nCol?.Attributes?["Title"]?.InnerText;
                this.pIsSum = nCol?.Attributes?["IsSum"]?.InnerText ?? "0";
                this.sPosition = nCol?.Attributes?["Position"]?.InnerText;
            }
        }
        //private AttributiesOfXML ReadFileXML(string xmlConfigPath)
        //{
        //    int startRow, contentRows;
        //    //Read xml config
        //    XmlDocument xmldocConfig = new XmlDocument();
        //    xmldocConfig.Load(xmlConfigPath);

        //    XmlNode nContent = xmldocConfig.SelectSingleNode("/XmlConfig/Content");
        //    //Dòng bắt đầu nội dung output
        //    string sStartRow = nContent?.Attributes?["StartRow"]?.InnerText;

        //    if (string.IsNullOrEmpty(sStartRow))
        //        throw new Exception("XmlConfig/Content[StartRow] is null or empty");
        //    if (!int.TryParse(sStartRow, out startRow))
        //    {
        //        throw new Exception("XmlConfig/Content[StartRow] invalid");
        //    }

        //    XmlNodeList nContentColList = xmldocConfig.SelectNodes("/XmlConfig/Content/Columns/Column");
        //    if (nContentColList == null || nContentColList.Count == 0)
        //    {
        //        throw new Exception("XmlConfig/Content/Columns/Column is null or empty");
        //    }

        //    //AttributiesOfXML AttributiesOfXML = new AttributiesOfXML();
        //    //XM
        //    //AttributiesOfXML.pIsSort = nCol?.Attributes?["IsSort"]?.InnerText ?? "0";
        //    //pColName = nCol?.Attributes?["Name"]?.InnerText ?? "";
        //    //pAlign = nCol?.Attributes?["Align"]?.InnerText ?? "Left";//(Left, Center, Right). Nếu ko tồn tại thì mặc định "Left"
        //    //pFormat = nCol?.Attributes?["Format"]?.InnerText;
        //    //pValue = nCol?.Attributes?["Value"]?.InnerText;
        //    //pValueName = nCol?.Attributes?["ValueName"]?.InnerText ?? "";
        //}
        public static void abc<T>(object p_object, ref int startRow, XmlNodeList nContentColList, ExcelWorksheet workSheet, int currentRow, bool isBackgroundColor)
        {


            startRow++;

            foreach (XmlNode nCol in nContentColList)
            {
                AttributiesOfXML attributeOfXML = new AttributiesOfXML(nCol);


                attributeOfXML.sPosition = nCol?.Attributes?["Position"]?.InnerText;
                if (!int.TryParse(attributeOfXML.sPosition, out attributeOfXML.pPosition))
                {
                    //Thông tin vị trí cell bắt buộc phải có
                    continue;
                }

                object cellValue = "";

                if (attributeOfXML.pIsSort.Equals("1"))
                {
                    cellValue = startRow;
                }
                else
                {
                    var propertiesMaster = typeof(T).GetProperty(attributeOfXML.pColName);
                    if (propertiesMaster != null)
                    {
                        var valueMaster = propertiesMaster.GetValue(p_object);
                        if (!attributeOfXML.pValueName.Equals(""))
                        {
                            string[] listValueNames = attributeOfXML.pValueName.Split(';');
                            foreach (string valueNameItem in listValueNames)
                            {
                                string[] listValueNameItems = valueNameItem.Split(':');
                                if (listValueNameItems[0].Trim().ToLower().Equals(valueMaster.ToString().ToLower()))
                                {
                                    cellValue = listValueNameItems[1].Trim();
                                }
                            }
                        }
                        else
                        {
                            cellValue = valueMaster;
                        }


                    }
                }

                workSheet.Cells[currentRow, attributeOfXML.pPosition].Value = cellValue;
                if (isBackgroundColor)
                {
                    Color colFromHex = System.Drawing.ColorTranslator.FromHtml("#D9D9D9");
                    workSheet.Cells[currentRow, attributeOfXML.pPosition].Style.Fill.BackgroundColor.SetColor(colFromHex);

                }
                StyleCell(workSheet, currentRow, attributeOfXML);
            }

        }

        public static void StyleCell(ExcelWorksheet workSheet, int currentRow, AttributiesOfXML attributiesOfXML)
        {

            // Set Style
            //---Set HorizontalAlignment
            SetAlignCell(workSheet.Cells[currentRow, attributiesOfXML.pPosition], attributiesOfXML.pAlign);

            //---Set Format
            SetFormatCell(workSheet.Cells[currentRow, attributiesOfXML.pPosition], attributiesOfXML.pFormat);

            //---Set Border
            SetBorderCell(workSheet.Cells[currentRow, attributiesOfXML.pPosition], OfficeOpenXml.Style.ExcelBorderStyle.Thin);

        }


        public static bool ExportFromTemplate<Parent, Master, Detail>(List<Parent> data, string xmlConfigPath, string outputPath, Dictionary<string, object> customData = null, List<string> columnDynamic = null, List<object> columnHeaderDynamic = null)
        {
            //data =  data.ToList<A<Master, Details>>();

            try
            {
                #region Check validation
                if (data == null || !data.Any())
                {
                    throw new Exception("Data is null or empty. Can not save to file");
                }

                #endregion

                //Read xml config
                XmlDocument xmldocConfig = new XmlDocument();
                xmldocConfig.Load(xmlConfigPath);

                #region Get Output File
                XmlNode nXmlConfig = xmldocConfig.SelectSingleNode("/XmlConfig");
                if (nXmlConfig == null)
                {
                    throw new Exception("XMLNode XmlConfig not exist in config file.");
                }
                //Output Template File
                var outputTemplatePath = System.Web.Hosting.HostingEnvironment.MapPath(nXmlConfig.Attributes?["OutputTemplatePath"]?.InnerText);
                if (!System.IO.File.Exists(outputTemplatePath))
                {
                    throw new Exception("Output template file is not exist!");
                }
                #endregion

                using (var package = new ExcelPackage(new FileInfo(outputTemplatePath)))
                {
                    ExcelWorksheet workSheet = package.Workbook.Worksheets.First();


                    int startRow, contentRows;
                    XmlNode nContent = xmldocConfig.SelectSingleNode("/XmlConfig/Content");
                    //Dòng bắt đầu nội dung output
                    string sStartRow = nContent?.Attributes?["StartRow"]?.InnerText;
                    if (string.IsNullOrEmpty(sStartRow))
                        throw new Exception("XmlConfig/Content[StartRow] is null or empty");
                    if (!int.TryParse(sStartRow, out startRow))
                    {
                        throw new Exception("XmlConfig/Content[StartRow] invalid");
                    }

                    contentRows = data.Count;


                    XmlNodeList nContentColList = xmldocConfig.SelectNodes("/XmlConfig/Content/Columns/Column");
                    if (nContentColList == null || nContentColList.Count == 0)
                    {
                        throw new Exception("XmlConfig/Content/Columns/Column is null or empty");
                    }

                    XmlNodeList nContentColDetailList = xmldocConfig.SelectNodes("/XmlConfig/Content/ColumnsDetail/Column");
                    if (nContentColList == null || nContentColList.Count == 0)
                    {
                        throw new Exception("XmlConfig/Content/ColumnsDetail/Column is null or empty");
                    }


                    // Loop through all data and add to worksheet
                    int currentRow = startRow;


                    PropertyInfo[] parentProperties = data.GetType().GetGenericArguments().Single().GetProperties();
                    int startColMaster = Convert.ToInt32(nContentColList[0].Attributes?["Position"]?.InnerText);
                    int lastColMaster = Convert.ToInt32(nContentColList[nContentColList.Count - 1].Attributes?["Position"]?.InnerText);
                    int startColDetail = Convert.ToInt32(nContentColDetailList[0].Attributes?["Position"]?.InnerText);
                    int lastColDetail = Convert.ToInt32(nContentColDetailList[nContentColDetailList.Count - 1].Attributes?["Position"]?.InnerText);

                    int startCol = 0;
                    int lastCol = 1;
                    if (lastColMaster >= lastColDetail)
                    {
                        startCol = lastColDetail;
                        lastCol = startColMaster;
                    }
                    else
                    {
                        startCol = startColMaster;
                        lastCol = lastColDetail;
                    }

                    int totalRows = 0;
                    totalRows += (data.Count - 1) * 2;

                    int startRowMaster = 0;
                    int curentRowMaster = currentRow;
                    List<AttributiesOfXML> tamp_MasterAttributies = new List<AttributiesOfXML>();
                    foreach (XmlNode nCol in nContentColList)
                    {
                        AttributiesOfXML attributeOfXML = new AttributiesOfXML(nCol);
                        if (!int.TryParse(attributeOfXML.sPosition, out attributeOfXML.pPosition))
                        {
                            //Thông tin vị trí cell bắt buộc phải có
                            continue;
                        }
                        if (attributeOfXML.pIsSum == "1")
                        {
                            tamp_MasterAttributies.Add(attributeOfXML);
                        }
                    }
                    foreach (Parent masterItem in data)
                    {
                        //currentRow++;
                        curentRowMaster = currentRow;
                        var master = parentProperties[0].GetValue(masterItem);

                        abc<Master>(master, ref startRowMaster, nContentColList, workSheet, currentRow, true);
                        SetBorderCell(workSheet.Cells[currentRow, startCol, currentRow, lastCol], OfficeOpenXml.Style.ExcelBorderStyle.Thin);

                        //Lấy ra data attribute của master
                        currentRow++;
                        workSheet.InsertRow(currentRow, 1);


                        foreach (XmlNode nCol in nContentColDetailList)
                        {
                            AttributiesOfXML attributiesOfXML = new AttributiesOfXML(nCol);

                            if (!int.TryParse(attributiesOfXML.sPosition, out attributiesOfXML.pPosition))
                            {
                                //Thông tin vị trí cell bắt buộc phải có
                                continue;
                            }
                            workSheet.Cells[currentRow, attributiesOfXML.pPosition].Value = attributiesOfXML.pTitle;
                            workSheet.Row(currentRow).OutlineLevel = 1;

                            StyleCell(workSheet, currentRow, attributiesOfXML);
                            SetBorderCell(workSheet.Cells[currentRow, startCol, currentRow, lastCol], OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        }
                        //SetFormatCell(workSheet.Cells[currentRow, nContentColList.Count - 1],  pFormat);

                        var detail = parentProperties[1].GetValue(masterItem);
                        var valueDetail = detail as List<Detail>;
                        currentRow++;
                        workSheet.InsertRow(currentRow, 1);

                        if (valueDetail.Count == 0)//Nếu không có dữ liệu chi tiết
                        {
                            workSheet.Row(currentRow).OutlineLevel = 1;
                            workSheet.Cells[currentRow, 2, currentRow, lastColDetail].Merge = true;
                            workSheet.Cells[currentRow, 2, currentRow, lastColDetail].Value = "Không có dữ liệu";
                            SetAlignCell(workSheet.Cells[currentRow, 2, currentRow, lastColDetail], "center");
                            SetBorderCell(workSheet.Cells[currentRow, startColMaster, currentRow, lastCol], OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                            currentRow++;
                            workSheet.InsertRow(currentRow, 1);
                            totalRows++;
                        }
                        else
                        {
                            int startRowDetail = 0;
                            List<AttributiesOfXML> tamp_DetailAttributies = new List<AttributiesOfXML>();
                            foreach (XmlNode nCol in nContentColDetailList)
                            {
                                AttributiesOfXML attributeOfXML = new AttributiesOfXML(nCol);
                                if (!int.TryParse(attributeOfXML.sPosition, out attributeOfXML.pPosition))
                                {
                                    //Thông tin vị trí cell bắt buộc phải có
                                    continue;
                                }
                                if (attributeOfXML.pIsSum == "1")
                                {
                                    tamp_DetailAttributies.Add(attributeOfXML);
                                }
                            }

                            foreach (Detail detailItem in valueDetail)
                            {
                                workSheet.Row(currentRow).OutlineLevel = 1;
                                abc<Detail>(detailItem, ref startRowDetail, nContentColDetailList, workSheet, currentRow, false);
                                SetBorderCell(workSheet.Cells[currentRow, startCol, currentRow, lastCol], OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                                currentRow++;
                                workSheet.InsertRow(currentRow, 1);
                                totalRows++;
                            }
                            if (tamp_DetailAttributies.Count > 0)
                            {
                                tamp_DetailAttributies = tamp_DetailAttributies.OrderBy(x => x.pPosition).ToList();
                                workSheet.Row(currentRow).OutlineLevel = 1;
                                workSheet.Cells[currentRow, startColDetail, currentRow, tamp_DetailAttributies.First().pPosition - 1].Merge = true;
                                workSheet.Cells[currentRow, startColDetail, currentRow, tamp_DetailAttributies.First().pPosition - 1].Value = "Tổng cộng: ";
                                workSheet.Cells[currentRow, startColDetail, currentRow, tamp_DetailAttributies.First().pPosition - 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                                SetBorderCell(workSheet.Cells[currentRow, startColMaster, currentRow, lastCol], OfficeOpenXml.Style.ExcelBorderStyle.Thin);


                                foreach (Detail detailItem in valueDetail)
                                {
                                    foreach (AttributiesOfXML attributiesOfXML in tamp_DetailAttributies)
                                    {
                                        int sum = Convert.ToInt32(typeof(Detail).GetProperty(attributiesOfXML.pColName).GetValue(detailItem));
                                        workSheet.Cells[currentRow, attributiesOfXML.pPosition].Value = Convert.ToInt32(workSheet.Cells[currentRow, attributiesOfXML.pPosition].Value) + sum;
                                        StyleCell(workSheet, currentRow, attributiesOfXML);
                                    }

                                }
                                currentRow++;
                                workSheet.InsertRow(currentRow, 1);
                                totalRows++;
                            }
                        }
                        workSheet.Cells[curentRowMaster + 1, startColMaster, currentRow - 1, startColDetail - 1].Merge = true;
                    }

                    if (tamp_MasterAttributies.Count > 0)
                    {
                        tamp_MasterAttributies = tamp_MasterAttributies.OrderBy(x => x.pPosition).ToList();
                        workSheet.Row(currentRow).OutlineLevel = 1;
                        workSheet.Cells[currentRow, startColMaster, currentRow, tamp_MasterAttributies.First().pPosition - 1].Merge = true;
                        workSheet.Cells[currentRow, startColMaster, currentRow, tamp_MasterAttributies.First().pPosition - 1].Value = "Tổng cộng: ";
                        workSheet.Cells[currentRow, startColMaster, currentRow, tamp_MasterAttributies.First().pPosition - 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                        SetBorderCell(workSheet.Cells[currentRow, startColMaster, currentRow, lastCol], OfficeOpenXml.Style.ExcelBorderStyle.Thin);


                        foreach (Parent masterItem in data)
                        {
                            var master = parentProperties[0].GetValue(masterItem);

                            foreach (AttributiesOfXML attributiesOfXML in tamp_MasterAttributies)
                            {
                                int sum = Convert.ToInt32(typeof(Master).GetProperty(attributiesOfXML.pColName).GetValue(master));
                                workSheet.Cells[currentRow, attributiesOfXML.pPosition].Value = Convert.ToInt32(workSheet.Cells[currentRow, attributiesOfXML.pPosition].Value) + sum;
                                StyleCell(workSheet, currentRow, attributiesOfXML);
                            }

                        }
                        currentRow++;
                        workSheet.InsertRow(currentRow, 1);
                        totalRows++;
                    }
                    //SetBorderCell(workSheet.Cells[startRow, startColDetail, startRow + totalRows + 1, lastColMaster], OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                    //SetBorderCell(workSheet.Cells[startRow + totalRows + 1, 1, startRow + totalRows + 1, lastColMaster], OfficeOpenXml.Style.ExcelBorderStyle.Thin);

                    #region Generate Custom Content (V2)

                    if (customData != null)
                    {
                        //Sheet2
                        XmlNodeList nCustomContentList = xmldocConfig.SelectNodes("/XmlConfig/CustomContents/CustomContent");
                        if (nCustomContentList != null && nCustomContentList.Count > 0)
                        {
                            foreach (XmlNode nCustomContent in nCustomContentList)
                            {
                                //Key trong Dictionary CustomData
                                var key = nCustomContent?.Attributes?["Key"]?.InnerText;
                                //Cell Name trong file template
                                var cellName = nCustomContent?.Attributes?["CellName"]?.InnerText;

                                if (!customData.ContainsKey(key))
                                    continue;

                                try
                                {
                                    var cellRange = workSheet.Workbook.Names[cellName];
                                    if (cellRange != null)
                                    {
                                        var value = customData[key] ?? "";
                                        var sTextTransform = nCustomContent?.Attributes?["TextTransform"]?.InnerText ?? "";
                                        switch (sTextTransform.ToLower())
                                        {
                                            case "uppercase":
                                                value = Convert.ToString(value).ToUpper();
                                                break;
                                            case "lowercase":
                                                value = Convert.ToString(value).ToLower();
                                                break;
                                            case "capitalize":
                                                break;
                                        }

                                        cellRange.Value = value;
                                    }
                                }
                                catch { }
                            }
                        }
                    }
                    #endregion

                    package.SaveAs(new FileInfo(outputPath));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
            }
            return true;
        }

        /// <summary>
        /// Get Header content for report
        /// </summary>
        /// <param name="siteID"></param>
        /// <param name="storeID"></param>
        /// <param name="reportName"></param>
        /// <param name="fiscalID"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        public static Dictionary<string, object> GetReportHeader(int siteID, string storeID, string reportName, Guid? fiscalID, DateTime? fromDate = null, DateTime? toDate = null)
        {
            var reval = new Dictionary<string, object>();
            try
            {
                using (var db = new StockManagementEntities())
                {

                    string reportDate = null;
                    if (fromDate != null && toDate != null)
                    {
                        //report time get by from,to date
                        //Từ ngày ……/…….. Đến ngày  ……./……./20…
                        reportDate = string.Format("Từ ngày {0}  Đến ngày {1}", ((DateTime)fromDate).ToString("dd/MM/yyyy"), ((DateTime)toDate).ToString("dd/MM/yyyy"));
                    }
                    else if (fromDate == null && toDate != null)
                    {
                        reportDate = string.Format("Đến ngày {0}", ((DateTime)toDate).ToString("dd/MM/yyyy"));
                    }
                    if (!string.IsNullOrEmpty(reportDate))
                    {
                        reval.Add("Report Date", reportDate);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return reval;
        }
        private static void SetBorderCell(ExcelRange cell, OfficeOpenXml.Style.ExcelBorderStyle borderStyle)
        {
            cell.Style.Border.Top.Style = borderStyle;
            cell.Style.Border.Bottom.Style = borderStyle;
            cell.Style.Border.Left.Style = borderStyle;
            cell.Style.Border.Right.Style = borderStyle;
        }

        private static void SetFormatCell(ExcelRange cell, string format)
        {
            if (!string.IsNullOrEmpty(format))
            {
                cell.Style.Numberformat.Format = format;
            }
        }

        private static void SetAlignCell(ExcelRange cell, string align)
        {
            if (!string.IsNullOrEmpty(align))
            {
                switch (align.ToLower())
                {
                    case "center":
                        cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        break;
                    case "right":
                        cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;
                        break;
                    default:
                        cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                        break;
                }
            }
        }

        private static void SetValueCell<T>(ExcelRange cell, T objT, string columnName)
        {
            object cellValue = "";
            if (typeof(T) == typeof(ExpandoObject))
            {
                //Dynamic ExpandoObject
                var objDict = objT as IDictionary<string, object>;
                if (objDict.ContainsKey(columnName))
                {
                    cellValue = objDict[columnName];
                }
            }
            else
            {
                //Object có cấu trúc
                var objProperty = typeof(T).GetProperty(columnName);
                if (objProperty != null)
                {
                    cellValue = objProperty.GetValue(objT);
                }
            }

            cell.Value = cellValue ?? "";
        }

    }

}