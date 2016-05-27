using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDataTable
{
    public partial class FrmPrincipal : Form
    {
        DataSet miDataSet;
        private static int cont = 0;
        public FrmPrincipal()
        {
            InitializeComponent();
            miDataSet = null;
        }

        private void btnDataST_Click(object sender, EventArgs e)
        {

            //instancio mi DataSet
            miDataSet = new DataSet();
            //agrego tabla Productos
            DataTable productos = new DataTable();
            productos.TableName = "Productos";
            productos.Columns.Add("IdProducto", typeof(Int32));
            productos.Columns.Add("Nombre", typeof(String));
            productos.Columns.Add("IdProveedor", typeof(Int32));

            productos.Columns["IdProducto"].AutoIncrement = true;
            productos.Columns["IdProducto"].AutoIncrementSeed = 1;
            productos.Columns["IdProducto"].AutoIncrementStep = 1;
            productos.Columns["IdProducto"].Unique = true;

            productos.PrimaryKey = new DataColumn[] { productos.Columns["IdProducto"] };

            //agrego tabla Proveedores
            DataTable proveedores = new DataTable();
            proveedores.TableName = "Proveedores";
            proveedores.Columns.Add("IdProveedor", typeof(Int32));
            proveedores.Columns.Add("IdLocalidades", typeof(Int32));
            proveedores.Columns.Add("Nombre", typeof(String));
            proveedores.PrimaryKey = new DataColumn[] { proveedores.Columns["IdProveedor"] };

            //agrego tabla Localidades

            DataTable localidades = new DataTable();
            localidades.TableName = "Localidades";
            localidades.Columns.Add("IdLocalidades", typeof(Int32));
            localidades.Columns.Add("Nombre", typeof(String));
            localidades.PrimaryKey = new DataColumn[] { localidades.Columns["IdLocalidades"] };

            // agrego las tablas a mi DataSet
            this.miDataSet.Tables.Add(proveedores);
            this.miDataSet.Tables.Add(productos);
            this.miDataSet.Tables.Add(localidades);


        }

        private void btnRelaciones_Click(object sender, EventArgs e)
        {
            DataRelation dstRelacion;

            dstRelacion = new DataRelation("ProveedoresProductos",
                                            miDataSet.Tables["Proveedores"].Columns["IdProveedor"],
                                            miDataSet.Tables["Productos"].Columns["IdProveedor"]);

            miDataSet.Relations.Add(dstRelacion);

            dstRelacion = new DataRelation("LocalidadesProveedores",
                                            miDataSet.Tables["Localidades"].Columns["IdLocalidades"],
                                            miDataSet.Tables["Proveedores"].Columns["IdLocalidades"]);

            miDataSet.Relations.Add(dstRelacion);


        }

        private void btnLocalidades_Click(object sender, EventArgs e)
        {
            this.miDataSet.Tables["Localidades"].Rows.Add(new object[] { 1, "Avellaneda" });
            this.miDataSet.Tables["Localidades"].Rows.Add(new object[] { 2, "Lanus" });
            this.miDataSet.Tables["Localidades"].Rows.Add(new object[] { 3, "Quilmes" });
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            this.miDataSet.Tables["Proveedores"].Rows.Add(new object[] { 1,1,"Roberto" });
            this.miDataSet.Tables["Proveedores"].Rows.Add(new object[] { 2,2, "Esteban" });
            this.miDataSet.Tables["Proveedores"].Rows.Add(new object[] { 3,3, "Carlos" });
            this.miDataSet.Tables["Proveedores"].Rows.Add(new object[] { 4, 3, "Juan Carlos" });
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.miDataSet.Tables["Productos"].Rows.Add(new object[] { 1, "Marihuana", 1 });
            this.miDataSet.Tables["Productos"].Rows.Add(new object[] { 2, "Cocaina",2 });
            this.miDataSet.Tables["Productos"].Rows.Add(new object[] { 3,"Paco",3 });
            this.miDataSet.Tables["Productos"].Rows.Add(new object[] { 4, "Gelatina", 3 });
        }

        private void btnProductoProveedor_Click(object sender, EventArgs e)
        {
            this.lstBox.Items.Clear();

            foreach (DataRow item in this.miDataSet.Tables["Productos"].Rows)
            {
                object[] arrayDeDatos = item.ItemArray;
                DataRow DataRowPadre = item.GetParentRow("ProveedoresProductos");
                object[] arrayDePadre = DataRowPadre.ItemArray;
                this.lstBox.Items.Add("ID: " + arrayDeDatos[0] + " Producto: "+ arrayDeDatos[1]
                    + "Proveedor: " + arrayDePadre[2]);
            }
        }

        private void btnProveedorLocalidad_Click(object sender, EventArgs e)
        {
            this.lstBox.Items.Clear();

            foreach (DataRow item in this.miDataSet.Tables["Localidades"].Rows)
            {
                object[] arrayDeDatos = item.ItemArray;
                DataRow[] DataRowHijo = item.GetChildRows("LocalidadesProveedores");
                object[] arrayDeHijo = DataRowHijo[0].ItemArray;

                this.lstBox.Items.Add("ID: " + arrayDeHijo[0] + " Proveedor: " + arrayDeHijo[2]
                    + "Localidad: " + arrayDeDatos[1]);
            }
        }

        private void btnProductoProvLoc_Click(object sender, EventArgs e)
        {
            this.lstBox.Items.Clear();

            foreach (DataRow proveedor in this.miDataSet.Tables["Proveedores"].Rows)
            {
                object[] arrayDeProv = proveedor.ItemArray;

                DataRow[] DataRowHijoProd = proveedor.GetChildRows("ProveedoresProductos");

                StringBuilder listaProductos = new StringBuilder();

                foreach (DataRow producto in DataRowHijoProd)
                {
                    object[] arrayDeHijoProd = producto.ItemArray;
                    listaProductos.AppendLine(arrayDeHijoProd[1].ToString()+" - ");

                }        

                DataRow DataRowPadreLoc = proveedor.GetParentRow("LocalidadesProveedores");
                object[] arrayDePadreLoc = DataRowPadreLoc.ItemArray;

                this.lstBox.Items.Add("Producto: " + listaProductos.ToString() + " Proveedor: " + arrayDeProv[2]
                    + " Localidad: " + arrayDePadreLoc[1]);
            }
        }

        private void btnProveedorLocQuilmes_Click(object sender, EventArgs e)
        {
            DataRow[] DataRowQuilmes = this.miDataSet.Tables["Localidades"].Select("Nombre = 'Quilmes' ");
            DataRow[] DataRowProv = DataRowQuilmes[0].GetChildRows("LocalidadesProveedores");

            this.lstBox.Items.Clear();
            foreach (DataRow item in DataRowProv)
            {
                  this.lstBox.Items.Add("ID: " + item[0] + " Proveedor: " + item[2]);
            }

        }

        private void btnProveedoresLocTxtFiltro_Click(object sender, EventArgs e)
        {
            string localidadAFiltrar = this.txtFiltro.Text;
            localidadAFiltrar.ToLower();
            localidadAFiltrar = char.ToUpper(localidadAFiltrar[0]) + localidadAFiltrar.Substring(1);

            if (localidadAFiltrar == "Quilmes" || localidadAFiltrar == "Avellaneda" ||
                localidadAFiltrar == "Lanus")
            {

                DataRow[] DataRowQuilmes = this.miDataSet.Tables["Localidades"].Select("Nombre = '"+localidadAFiltrar+"' ");
                DataRow[] DataRowProv = DataRowQuilmes[0].GetChildRows("LocalidadesProveedores");

                this.lstBox.Items.Clear();
                foreach (DataRow item in DataRowProv)
                {
                    this.lstBox.Items.Add("ID: " + item[0] + " Proveedor: " + item[2]);
                }
            }
            else
                MessageBox.Show("Localidad invalida, reingrese!");
        }
    }
}
