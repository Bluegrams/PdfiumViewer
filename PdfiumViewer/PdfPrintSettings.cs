using System;
using System.Collections.Generic;
using System.Text;

namespace PdfiumViewer
{
    /// <summary>
    /// Configures the print document.
    /// </summary>
    public class PdfPrintSettings
    {

        /// <summary>
        /// Gets the default printing configuration
        /// </summary>
        public static PdfPrintSettings DefaultPrinterSettings =
            new PdfPrintSettings(PdfPrintMode.CutMargin, 1.0);

        /// <summary>
        /// Gets the mode used to print margins.
        /// </summary>
        public PdfPrintMode Mode { get; }

        /// <summary>
        /// Gets configuration for printing multiple PDF pages on a single page.
        /// </summary>
        public PdfPrintMultiplePages MultiplePages { get; }

        /// <summary>
        /// Gets the scale factor when Scaling is "Scale"
        /// </summary>
        public double ScaleFactor { get; }

        /// <summary>
        /// Creates a new instance of the PdfPrintSettings class.
        /// </summary>
        /// <param name="mode">The mode used to print margins.</param>
        /// <param name="scaleFactor">The scale factor.</param>
        public PdfPrintSettings(PdfPrintMode mode, double scaleFactor)
        {
            Mode = mode;
            ScaleFactor = scaleFactor;
        }

        /// <summary>
        /// Creates a new instance of the PdfPrintSettings class.
        /// </summary>
        /// <param name="mode">The mode used to print margins.</param>
        /// <param name="scaleFactor">The scale factor.</param>
        /// <param name="multiplePages">Configuration for printing multiple PDF
        /// pages on a single page.</param>
        public PdfPrintSettings(PdfPrintMode mode, double scaleFactor, PdfPrintMultiplePages multiplePages) : this(mode, scaleFactor)
        {
            MultiplePages = multiplePages;
        }
    }
}
