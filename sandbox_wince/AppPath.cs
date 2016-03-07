////
/// Copyright (c) 2016 Saúl Piña <sauljabin@gmail.com>.
/// 
/// This file is part of xmlrpcwsc.
/// 
/// xmlrpcwsc is free software: you can redistribute it and/or modify
/// it under the terms of the GNU Lesser General Public License as published by
/// the Free Software Foundation, either version 3 of the License, or
/// (at your option) any later version.
/// 
/// xmlrpcwsc is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/// GNU Lesser General Public License for more details.
/// 
/// You should have received a copy of the GNU Lesser General Public License
/// along with xmlrpcwsc.  If not, see <http://www.gnu.org/licenses/>.
////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace sandbox_wince {

    /// <summary>
    /// Class for path
    /// </summary>
    public sealed class AppPath {

        /// <summary>
        /// Get chars invalid for files name
        /// </summary>
        /// <returns>Array char</returns>
        public static char[] GetInvalidFileNameChars() {
            return new char[] { (Char)0, (Char)1, (Char)2, (Char)3, (Char)4, (Char)5, (Char)6, (Char)7, (Char)8, (Char)9, (Char)10, (Char)11, (Char)12, (Char)13, (Char)14, (Char)15, (Char)16, (Char)17, (Char)18, (Char)19, (Char)20, (Char)21, (Char)22, (Char)23, (Char)24, (Char)25, (Char)26, (Char)27, (Char)28, (Char)29, (Char)30, (Char)31, (Char)34, (Char)42, (Char)47, (Char)58, (Char)60, (Char)62, (Char)63, (Char)92, (Char)124 };
        }

        /// <summary>
        /// Get a file name valid for string
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <returns>File name valid</returns>
        public static string GetValidFileName(string fileName) {
            foreach (char c in GetInvalidFileNameChars()) {
                fileName = fileName.Replace(c, '_');
            }
            return fileName;
        }

        // <summary>
        /// Get app path
        /// </summary>
        /// <returns>App path</returns>
        public static string GetAppPath() {
            return Uri.UnescapeDataString((new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase))).AbsolutePath);
        }

        /// <summary>
        /// Get path for file resource
        /// </summary>
        /// <param name="path">Relative path of file</param>
        /// <returns>Absolute path of file</returns>
        public static string GetAppPath(string path) {
            if (!path.StartsWith("/"))
                path = "/" + path;
            return GetAppPath() + path;
        }
    }
}
