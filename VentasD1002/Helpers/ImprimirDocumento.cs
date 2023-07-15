using BusVenta;
using BusVenta.Helpers;
using DatVentas;
using EntVenta;
using Reportes;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Reporting.Processing;
using Telerik.ReportViewer.WinForms;

namespace VentasD1002.Helpers
{
   public class ImprimirDocumento
    {
        public static OperationResponse Imprimir(ref ReportViewer reportViewer, DESTINO_DOCUMENTO DESTINO, TIPO_DOCUMENTO DOCUMENTO, int idVenta)
        {
            try
            {
                ParametrosReporte dataReport = DatVenta.Consultar_Ticket_Parametro(idVenta);
                dataReport.LetraNumero = Convertir_NumeroLetra.NumeroATexto(dataReport.MontoTotal.ToString());
                var serialPC = Sistema.ObenterSerialPC();
                var impresora = CajaDAL.ObtenerImpresora(DOCUMENTO.ToString(), serialPC);

                if (String.IsNullOrEmpty(impresora) || impresora == "NINGUNA")
                {
                    return OperationResponse.Warning("No existe una impresora configurada pra imprimir, favor de revisar");
                }

                PrintDocument printDocument = new PrintDocument();
                printDocument.PrinterSettings.PrinterName = impresora;
                //ReportViewer reportViewer = new ReportViewer();

                if (DESTINO == DESTINO_DOCUMENTO.VENTAS)
                {
                    switch (DOCUMENTO)
                    {
                        case TIPO_DOCUMENTO.TICKET:
                            var ticket = new ReportTicket(dataReport);
                            reportViewer.Report = ticket;
                            break;
                        case TIPO_DOCUMENTO.REPORTE:
                            rtpRecibo recibo = new rtpRecibo(dataReport);
                            reportViewer.Report = recibo;
                            break;
                        default:
                            break;
                    }
                }
                else
                {

                }

                reportViewer.RefreshReport();

                if (printDocument.PrinterSettings.IsValid)
                {
                    PrinterSettings printerSettings = new PrinterSettings();
                    printerSettings.PrinterName = impresora;

                    ReportProcessor reportProcessor = new ReportProcessor();
                    reportProcessor.PrintReport(reportViewer.ReportSource, printerSettings);

                    return OperationResponse.Success();
                }
                else
                {
                    return OperationResponse.Warning("No se pudo conectar con la impresora configurada, favor de revisar");
                }

            }
            catch (Exception ex)
            {
                return OperationResponse.Failure(ex.Message);
            }
        }

        public static OperationResponse DibujarReporte(ref ReportViewer reportViewer, DESTINO_DOCUMENTO DESTINO, TIPO_DOCUMENTO DOCUMENTO, int idVenta)
        {
            try
            {
                ParametrosReporte dataReport = DatVenta.Consultar_Ticket_Parametro(idVenta);
                dataReport.LetraNumero = Convertir_NumeroLetra.NumeroATexto(dataReport.MontoTotal.ToString());

                if (DESTINO == DESTINO_DOCUMENTO.VENTAS)
                {
                    switch (DOCUMENTO)
                    {
                        case TIPO_DOCUMENTO.TICKET:
                            var ticket = new ReportTicket(dataReport);
                            reportViewer.Report = ticket;
                            break;
                        case TIPO_DOCUMENTO.REPORTE:
                            rtpRecibo recibo = new rtpRecibo(dataReport);
                            reportViewer.Report = recibo;
                            break;
                        default:
                            break;
                    }
                }
                else
                {

                }

                reportViewer.RefreshReport();
                return OperationResponse.Success("OK");
            }
            catch (Exception ex)
            {
                return OperationResponse.Failure(ex.Message);
            }
        }

        public static OperationResponse Imprimir(ref ReportViewer reportViewer,TIPO_DOCUMENTO DOCUMENTO)
        {
            try
            {
                var serialPC = Sistema.ObenterSerialPC();
                var impresora = CajaDAL.ObtenerImpresora(DOCUMENTO.ToString(), serialPC);

                if (String.IsNullOrEmpty(impresora) || impresora == "NINGUNA")
                {
                    return OperationResponse.Warning("No existe una impresora configurada pra imprimir, favor de revisar");
                }

                PrintDocument printDocument = new PrintDocument();
                printDocument.PrinterSettings.PrinterName = impresora;

                reportViewer.RefreshReport();

                if (printDocument.PrinterSettings.IsValid)
                {
                    PrinterSettings printerSettings = new PrinterSettings();
                    printerSettings.PrinterName = impresora;

                    ReportProcessor reportProcessor = new ReportProcessor();
                    reportProcessor.PrintReport(reportViewer.ReportSource, printerSettings);

                    return OperationResponse.Success();
                }
                else
                {
                    return OperationResponse.Warning("No se pudo conectar con la impresora configurada, favor de revisar");
                }

            }
            catch (Exception ex)
            {
                return OperationResponse.Failure(ex.Message);
            }
        }
    }
}
