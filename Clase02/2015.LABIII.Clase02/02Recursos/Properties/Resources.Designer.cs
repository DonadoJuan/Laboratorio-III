﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _02Recursos.Properties {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("_02Recursos.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap bamboo {
            get {
                object obj = ResourceManager.GetObject("bamboo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Busca un recurso adaptado de tipo System.Drawing.Icon similar a (Icono).
        /// </summary>
        internal static System.Drawing.Icon Help {
            get {
                object obj = ResourceManager.GetObject("Help", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a ---------------------------------------------------------
        ///Prefijo		Control			Ejemplo
        ///---------------------------------------------------------
        ///txt		TextBox			txtEdad
        ///lbl		Label			lblNombre
        ///btn		Button			btnAceptar	
        ///cbo		ComboBox		cboPaises
        ///frm		Form			frmPrincipal
        ///lst		ListView/ListBox	lstListado
        ///msk		MaskedTextBox		mskFecha
        ///grp		GroupBox		grpIntereses
        ///pic		PictureBox		picFoto
        ///chk		CheckBox		chkOpcion
        ///rdo		RadioButton		rdoSexo
        ///img		Image			imgFondo
        ///clb		CheckedListBox		clbLista
        ///dgv		DataGrid [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string Prefijos {
            get {
                return ResourceManager.GetString("Prefijos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream winAquariumDefault {
            get {
                return ResourceManager.GetStream("winAquariumDefault", resourceCulture);
            }
        }
    }
}
