using DevExpress.Web;
using DevExpress.Web.Mvc;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace waterwork.DAL
{
    public class GridViewExportDemoHelper
    {
        public enum GridViewExportFormat { None, Pdf, Xls, Xlsx, Rtf, Csv }
        public delegate ActionResult GridViewExportMethod(GridViewSettings settings, object dataObject);
        static Dictionary<GridViewExportFormat, GridViewExportMethod> exportFormatsInfo;
        public static Dictionary<GridViewExportFormat, GridViewExportMethod> ExportFormatsInfo
        {
            get
            {
                if (exportFormatsInfo == null)
                    exportFormatsInfo = CreateExportFormatsInfo();
                return exportFormatsInfo;
            }
        }
        static Dictionary<GridViewExportFormat, GridViewExportMethod> CreateExportFormatsInfo()
        {
            return new Dictionary<GridViewExportFormat, GridViewExportMethod> {
                { GridViewExportFormat.Pdf, GridViewExtension.ExportToPdf },
                {
                    GridViewExportFormat.Xls,
                    (settings, data) => GridViewExtension.ExportToXls(settings, data, new XlsExportOptionsEx { ExportType = DevExpress.Export.ExportType.WYSIWYG })
                },
                {
                    GridViewExportFormat.Xlsx,
                    (settings, data) => GridViewExtension.ExportToXlsx(settings, data, new XlsxExportOptionsEx { ExportType = DevExpress.Export.ExportType.WYSIWYG })
                },
                { GridViewExportFormat.Rtf, GridViewExtension.ExportToRtf },
                {
                    GridViewExportFormat.Csv,
                    (settings, data) => GridViewExtension.ExportToCsv(settings, data, new CsvExportOptionsEx { ExportType = DevExpress.Export.ExportType.WYSIWYG })
                }
            };
        }
        static Dictionary<GridViewExportFormat, GridViewExportMethod> formatConditionsExportFormatsInfo;
        public static Dictionary<GridViewExportFormat, GridViewExportMethod> FormatConditionsExportFormatsInfo
        {
            get
            {
                if (formatConditionsExportFormatsInfo == null)
                    formatConditionsExportFormatsInfo = CreateFormatConditionsExportFormatsInfo();
                return formatConditionsExportFormatsInfo;
            }
        }
        static Dictionary<GridViewExportFormat, GridViewExportMethod> CreateFormatConditionsExportFormatsInfo()
        {
            return new Dictionary<GridViewExportFormat, GridViewExportMethod> {
                { GridViewExportFormat.Pdf, GridViewExtension.ExportToPdf},
                { GridViewExportFormat.Xls, (settings, data) => GridViewExtension.ExportToXls(settings, data) },
                { GridViewExportFormat.Xlsx,
                    (settings, data) => GridViewExtension.ExportToXlsx(settings, data, new XlsxExportOptionsEx {ExportType = DevExpress.Export.ExportType.WYSIWYG})
                },
                { GridViewExportFormat.Rtf, GridViewExtension.ExportToRtf }
            };
        }
        static GridViewSettings exportGridViewSettings;
        public static GridViewSettings ExportGridViewSettings
        {
            get
            {
                if (exportGridViewSettings == null)
                    exportGridViewSettings = CreateExportGridViewSettings();
                return exportGridViewSettings;
            }
        }
        static GridViewSettings CreateExportGridViewSettings()
        {
            GridViewSettings settings = new GridViewSettings();

            settings.Name = "gvExport";
            settings.CallbackRouteValues = new { Controller = "Exporting", Action = "ExportPartial" };
            settings.Width = Unit.Percentage(100);

            settings.Columns.Add(set =>
            {
                set.FieldName = "Water_usage.Createinvoiceperiods.date";
                set.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            });
            settings.Columns.Add("water_usagefirst");
            settings.Columns.Add("water_usageafter");
            settings.Columns.Add("unit");
            settings.Columns.Add("service_charge");
            settings.Columns.Add("Minimum_rate");
            settings.Columns.Add("price");
            settings.Columns.Add("status");
            return settings;
        }

    }
}