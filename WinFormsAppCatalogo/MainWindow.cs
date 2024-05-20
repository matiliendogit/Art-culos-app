using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using utilidades;

namespace WinFormsAppCatalogo
{
    public partial class MainWindow : Form
    {
        private List<Articulo> listaArticulo;
        public MainWindow()
        {
            InitializeComponent();
        }

        private Validaciones validar = new Validaciones();

        private void MainWindow_Load(object sender, EventArgs e)
        {
            cargarLista();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoría");
            cboCampo.Items.Add("Precio");
            if (cboCampo.SelectedItem == null || cboCriterio.SelectedItem == null)
            {
                btnFiltrar.Enabled = false;
                return;
            }
        }

        private void cargarLista()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulo = negocio.listar();
                dgvListaArticulos.DataSource= listaArticulo;

                ocultarColumnas();
                cargarImagen(listaArticulo[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error inesperado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void ocultarColumnas()
        {
            dgvListaArticulos.Columns["Id"].Visible = false;
            dgvListaArticulos.Columns["ImagenUrl"].Visible = false;
        }

        private void cargarImagen(string url)
        {
            try
            {
                pboImagenArticulo.Load(url);
            }
            catch (Exception ex)
            {
                pboImagenArticulo.Load("https://gesisarg.com/sistema-gestion/res/archivos/imagen_articulo_por_defecto.jpg");
            }
        }

        private void dgvListaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvListaArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaModificacion alta = new frmAltaModificacion();
            alta.ShowDialog();
            cargarLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            abrirModificar();

        }

        private void dgvListaArticulos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            abrirModificar();
        }

        private void abrirModificar()
        {
            if(dgvListaArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;

                frmAltaModificacion modificar = new frmAltaModificacion(seleccionado);
                modificar.ShowDialog();
                cargarLista();
            }           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                if (dgvListaArticulos.CurrentRow == null)
                    return;
                seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("De verdad deseas eliminar el artículo '"+seleccionado.Nombre+"' ", "Eliminando artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado.Id);
                    MessageBox.Show("Artículo: '"+seleccionado.Nombre+"', eliminado exitosamente de la base de datos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cargarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error inesperado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroRapido.Text;

            if(filtro.Length >= 2)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Precio.ToString().ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dgvListaArticulos.DataSource = null;
            dgvListaArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cboCampo.SelectedItem.ToString();
            if(campo == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Igual a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.SelectedIndex= 0;
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
                cboCriterio.SelectedIndex = 0;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio= new ArticuloNegocio();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;

                if(campo == "Precio" && !string.IsNullOrWhiteSpace(filtro))
                {
                    if (!validar.esNumero(filtro))
                    {
                        MessageBox.Show("Debes ingresar un valor numérico, ej. '452.90'", "Filtro incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }else if (!validar.esPrecioValido(filtro))
                    {
                        MessageBox.Show("Debes ingresar un valor numérico, ej. '452.90'", "Filtro incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    dgvListaArticulos.DataSource = negocio.filtrar(campo, criterio, filtro, true);
                }
                else
                {
                    dgvListaArticulos.DataSource = negocio.filtrar(campo, criterio, filtro, false);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error inesperado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCriterio.SelectedItem != null && cboCampo.SelectedItem != null)
                btnFiltrar.Enabled = true;
        }

        private void lblEliminarFiltros_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cargarLista();
        }

        private void pboImagenArticulo_Click(object sender, EventArgs e)
        {
            if (dgvListaArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;

                frmAltaModificacion modificar = new frmAltaModificacion(seleccionado);
                modificar.ShowDialog();
                cargarLista();
            }

        }
    }

    
}
