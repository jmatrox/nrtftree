using System.Drawing;
using Net.Sgoliver.NRtfTree.Core;
using Net.Sgoliver.NRtfTree.Util;

namespace nrtftree_library
{
    /// <summary>
    /// Classe per allineare
    /// </summary>
    public class RtfAdjust : RtfMerger
    {

        #region Constructors

        /// <summary>
        /// Costruttore di classe
        /// </summary>
        /// <param name="templatePath"></param>
        public RtfAdjust(string templatePath): base(templatePath)
        {
        }

        /// <summary>
        /// Costruttore di classe
        /// </summary>
        /// <param name="rtfTree"></param>
        public RtfAdjust(RtfTree rtfTree): base(rtfTree)
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Aggiusta i FONT del documento da inserire.
        /// </summary>
        /// <param name="docToInsert">Documento da inserire.</param>
        public void MainAdjustFont(RtfTree docToInsert)
        {
            mainAdjustFont(docToInsert);
        }

        /// <summary>
        /// Ajusta los colores del documento a insertar.
        /// </summary>
        /// <param name="docToInsert">Documento a insertar.</param>
        public void MainAdjustColor(RtfTree docToInsert)
        {
            mainAdjustColor(docToInsert);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="docToInsert"></param>
        public void MainAdjustStyle(RtfTree docToInsert)
        {
            mainAdjustStyle(docToInsert);
        }

        #endregion
    }
}
