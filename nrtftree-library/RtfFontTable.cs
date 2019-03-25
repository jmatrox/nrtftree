/********************************************************************************
 *   This file is part of NRtfTree Library.
 *
 *   NRtfTree Library is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU Lesser General Public License as published by
 *   the Free Software Foundation; either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   NRtfTree Library is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU Lesser General Public License for more details.
 *
 *   You should have received a copy of the GNU Lesser General Public License
 *   along with this program. If not, see <http://www.gnu.org/licenses/>.
 ********************************************************************************/

/********************************************************************************
 * Library:		NRtfTree
 * Version:     v0.4
 * Date:		29/06/2013
 * Copyright:   2006-2013 Salvador Gomez
 * Home Page:	http://www.sgoliver.net
 * GitHub:	    https://github.com/sgolivernet/nrtftree
 * Class:		RtfFontTable
 * Description:	Tabla de Fuentes de un documento RTF.
 * ******************************************************************************/

using System.Collections.Generic;
using System.Collections;

namespace Net.Sgoliver.NRtfTree
{
    namespace Util
    {
        /// <summary>
        /// Tabla de fuentes de un documento RTF.
        /// </summary>
        public class RtfFontTable
        {
            /// <summary>
            /// Lista interna de fuentes.
            /// </summary>
            private Dictionary<int,RtfFont> fonts;

            /// <summary>
            /// Constructor de la clase RtfFontTable.
            /// </summary>
            public RtfFontTable()
            {
                fonts = new Dictionary<int, RtfFont>();
            }

            /// <summary>
            /// Inserta un nueva fuente en la tabla de fuentes.
            /// </summary>
            /// <param name="font">Nueva fuente a insertar.</param>
            public void AddFont(RtfFont font)
            {
                font.Index = newFontIndex();

                fonts.Add(font.Index,font);
            }

            /// <summary>
            /// Inserta un nueva fuente en la tabla de fuentes.
            /// </summary>
            /// <param name="index">Indice de la fuente a insertar.</param>
            /// <param name="font">Nueva fuente a insertar.</param>
            public void AddFont(int index, RtfFont font)
            {
                font.Index = index;

                fonts.Add(index, font);
            }

            /// <summary>
            /// Obtiene la fuente n-�sima de la tabla de fuentes.
            /// </summary>
            /// <param name="index">Indice de la fuente a recuperar.</param>
            /// <returns>Fuente n-�sima de la tabla de fuentes.</returns>
            public RtfFont this[int index]
            {
                get
                {
                    return fonts[index];
                }
            }

            /// <summary>
            /// N�mero de fuentes en la tabla.
            /// </summary>
            public int Count
            {
                get 
                {
                    return fonts.Count;
                }
            }

            /// <summary>
            /// Obtiene el �ndice de una fuente determinado en la tabla.
            /// </summary>
            /// <param name="font">Fuente a consultar.</param>
            /// <returns>Indice de la fuente consultada.</returns>
            public int IndexOf(RtfFont font)
            {
                int intIndex = -1;
                IEnumerator fntIndex = fonts.GetEnumerator();

                fntIndex.Reset();
                while (fntIndex.MoveNext())
                {
                    if (((KeyValuePair<int,RtfFont>)fntIndex.Current).Value.Equals(font))
                    {
                        intIndex = (int)((KeyValuePair<int, RtfFont>)fntIndex.Current).Key;
                        break;
                    }
                }

                return intIndex;
            }

            /// <summary>
            /// Obtiene un �ndice que no se est� usando en la tabla.
            /// </summary>
            /// <returns>Obtiene un �ndice que no se est� usando en la tabla.</returns>
            private int newFontIndex()
            {
                int intIndex = -1;
                IEnumerator fntIndex = fonts.GetEnumerator();

                fntIndex.Reset();
                while (fntIndex.MoveNext())
                {
                    if ((int)((KeyValuePair<int, RtfFont>)fntIndex.Current).Key > intIndex)
                        intIndex = (int)((KeyValuePair<int, RtfFont>)fntIndex.Current).Key;
                }

                return (intIndex + 1);
            }
        }
    }
}
