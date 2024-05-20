using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using dominio;
using negocio;
using utilidades;
using System.Drawing.Text;
using System.Text.RegularExpressions;

namespace WinFormsAppCatalogo
{
    public partial class frmAltaModificacion : Form
    {
        private Articulo articulo = null;

        private Marca newMarca = null;

        private Categoria newCateg = null;

        private OpenFileDialog imagenLocal = null;

        private bool imagenLocalGuardada = false;

        private Validaciones validar = null;

        public frmAltaModificacion()
        {
            InitializeComponent();
        }

        public frmAltaModificacion(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificando artículo: '" + articulo.Nombre + "' ";
        }

        private void AltaModificacion_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            

            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    txtImagenUrl.Text= articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.ToString();
                }
                else { cargarImagen(""); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error inesperado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio= new ArticuloNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            validar = new Validaciones();

            try
            {
                if(articulo == null)
                {
                    articulo = new Articulo();
                }
                newMarca = new Marca();
                newCateg = new Categoria();

                //---Validaciones---//

                foreach (Control control in Controls)
                {
                    if(control is TextBox || control is ComboBox)
                    {
                        control.BackColor = SystemColors.Window;

                        if (control.Name != "txtImagenUrl")
                        {
                            if (string.IsNullOrWhiteSpace(control.Text))
                            {
                                MessageBox.Show("Debes ingresar todos los campos obligatorios", "Error formulario",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                                mostrarLblObligatorias();
                               
                                return;
                            }
                        }                       
                    }               
                }

                if (!validar.esNumero(txtPrecio.Text))
                {
                    txtPrecio.BackColor= SystemColors.Window;
                    MessageBox.Show("Debes ingresar solo números", "Error en Precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrecio.BackColor= Color.IndianRed;
                    return;
                }
                else if (!validar.esPrecioValido(txtPrecio.Text))
                {
                    MessageBox.Show("Debes ingresar un precio válido, ej.: '4500.99'", "Error en Precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrecio.BackColor = Color.IndianRed;
                    return;
                }
                else if (!validar.precioEnRango(txtPrecio.Text, 100m, 100000000m))
                {
                    MessageBox.Show("El precio debe ser mayor a 100 y menor a 100 millones", "Error en Precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrecio.BackColor = Color.IndianRed;
                    return;
                }
            
                if (!validar.EsCodigoValido(txtCodigo.Text))
                { 
                    MessageBox.Show("Debes ingresar un código válido, ej.: 'A030'", "Error en Código", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.BackColor = Color.IndianRed;
                    return;
                }

                if(!validar.caracteresEnRango(txtNombre.Text, 2, 1000))
                {
                    MessageBox.Show("Mínimo 3 y máximo 1000 caracteres", "Error en Nombre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.BackColor = Color.IndianRed;
                    return;
                }
                else if (!validar.EsSoloLetras(validar.ObtenerPrimeraPalabra(txtNombre.Text)))
                {
                    MessageBox.Show("Nombre no válido: primera palabra solo letras", "Error en Nombre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.BackColor= Color.IndianRed;
                    return;
                }

                if (!validar.caracteresEnRango(txtDescripcion.Text, 10, 10000))
                {
                    MessageBox.Show("Mínimo 10 y máximo 10000 caracteres", "Error en Descripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcion.BackColor = Color.IndianRed;
                    return;
                }
                else if (validar.cantidadDePalabras(txtDescripcion.Text) < 2)
                {
                    MessageBox.Show("Descripción demasiado corta", "Error en Descripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcion.BackColor = Color.IndianRed;
                    return;
                }

                //--------------//

                DialogResult respuesta = MessageBox.Show("Está seguro que desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(respuesta != DialogResult.Yes)
                    return;
            
                articulo.Codigo = txtCodigo.Text.Trim();
                articulo.Nombre= primerasLetrasMayusculas(txtNombre.Text, false);
                articulo.Descripcion = primerasLetrasMayusculas(txtDescripcion.Text, true);
                articulo.Precio = decimal.Parse(txtPrecio.Text.Trim());

                string pathImagen = guardarImagenLocal();
                if (imagenLocalGuardada)
                {
                    articulo.ImagenUrl = pathImagen;
                }
                else
                {
                    articulo.ImagenUrl = txtImagenUrl.Text.Trim();  
                }

                newMarca.Descripcion = primerasLetrasMayusculas(cboMarca.Text, false);
                articulo.Marca = marcaNegocio.buscarPorDescrip(newMarca.Descripcion);
                if (articulo.Marca.Descripcion == null)
                {
                    marcaNegocio.agregar(newMarca);
                    articulo.Marca = marcaNegocio.buscarPorDescrip(newMarca.Descripcion);
                }

                newCateg.Descripcion = primerasLetrasMayusculas(cboCategoria.Text, true);
                articulo.Categoria = categoriaNegocio.buscarPorDescrip(newCateg.Descripcion);
                if (articulo.Categoria.Descripcion == null)
                {
                    categoriaNegocio.agregar(newCateg);
                    articulo.Categoria = categoriaNegocio.buscarPorDescrip(newCateg.Descripcion);
                }


                if (articulo.Id == 0)
                {
                    negocio.agregar(articulo);                   
                    MessageBox.Show(" '" + articulo.Nombre + "' agregado exitosamente");
                }
                else
                {
                    negocio.modificar(articulo);
                    MessageBox.Show(" '"+articulo.Nombre+"' modificado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error inesperado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private string guardarImagenLocal()
        {
            string rutaDestino = "";
            string rutaRelativa = ConfigurationManager.AppSettings["images-folder"];
            string rutaAbsoluta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaRelativa);
            if (imagenLocal != null && !(txtImagenUrl.Text.Trim().ToUpper().Contains("HTTP")))
            {
                DateTime fechaHoraActual = DateTime.Now;
                string fechaHoraFormateada = fechaHoraActual.ToString("yyyyMMdd_HHmmss");
                rutaDestino = Path.Combine(rutaAbsoluta, $"{fechaHoraFormateada}_{imagenLocal.SafeFileName}");

                string directorioDestino = Path.GetDirectoryName(rutaDestino);
                if (!Directory.Exists(directorioDestino))
                {
                    Directory.CreateDirectory(directorioDestino);
                }

                File.Copy(imagenLocal.FileName, rutaDestino);

                imagenLocalGuardada = true;
            }
            return rutaDestino;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            imagenLocal = new OpenFileDialog();
            imagenLocal.Filter = "jpg|*.jpg; |png|*.png; |jpeg|*.jpeg";
            if(imagenLocal.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = imagenLocal.FileName;
                cargarImagen(imagenLocal.FileName);
            }
            else
            {
                imagenLocal = null;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private string primerasLetrasMayusculas(string texto, bool soloLaPrimera)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            string[] palabras = texto.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (soloLaPrimera)
            {
                if (char.IsLetter(palabras[0][0]))
                {
                    if (palabras[0].Any(letra => char.IsUpper(letra)))
                    {
                        palabras[0] = char.ToUpper(palabras[0][0]) + palabras[0].Substring(1);
                    }
                    else
                    {
                        palabras[0] = char.ToUpper(palabras[0][0]) + palabras[0].Substring(1).ToLower();
                    }
                }
                else
                {
                    if (palabras[0].Any(letra => char.IsUpper(letra)))
                    {
                        palabras[0] = palabras[0][0] + palabras[0].Substring(1);
                    }
                    else
                    {
                        palabras[0] = palabras[0][0] + palabras[0].Substring(1).ToLower();
                    }
                }
                return String.Join(" ", palabras);
            }

            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 0)
                {
                    if (char.IsLetter(palabras[i][0]))
                    {
                        if (palabras[i].Any(letra => char.IsUpper(letra)))
                        {
                            palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1);
                        }else
                        {
                            palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1).ToLower();
                        }
                    }
                    else
                    {
                        if (palabras[i].Any(letra => char.IsUpper(letra)))
                        {
                            palabras[i] = palabras[i][0] + palabras[i].Substring(1);
                        }
                        else
                        {
                            palabras[i] = palabras[i][0] + palabras[i].Substring(1).ToLower();
                        }
                    }
                }
            }
            
            return String.Join(" ", palabras);
        }

        private void mostrarLblObligatorias()
        {
            foreach (Control control in Controls)
            {
                if (control is Label && control.Name.Contains("Obligatorio"))
                {
                    control.Visible = true;
                }
            }
        }

        private void btnNewMarca_Click(object sender, EventArgs e)
        {
            cboMarca.DropDownStyle= ComboBoxStyle.DropDownList;
            cboMarca.SelectedIndex= -1;
            cboMarca.DropDownStyle = ComboBoxStyle.Simple;
            cboMarca.Focus();
            newMarca = new Marca();
        }

        private void cboMarca_Leave(object sender, EventArgs e)
        {
            if (newMarca != null)
            {
                manejarNewItemsCboBox(cboMarca, btnNewMarca);
            }
        }

        private void btnNewCategoria_Click(object sender, EventArgs e)
        {
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.SelectedIndex = -1;
            cboCategoria.DropDownStyle = ComboBoxStyle.Simple;
            cboCategoria.Focus();
            newCateg = new Categoria();

        }

        private void cboCategoria_Leave(object sender, EventArgs e)
        {
            if(newCateg != null)
            {
                manejarNewItemsCboBox(cboCategoria, btnNewCategoria);
            }
        }

        private void manejarNewItemsCboBox(ComboBox cboBox, Button btn)
        {
            cboBox.BackColor = SystemColors.Window;
            string texto;
            string prop = cboBox.Name.Substring(3);
            Validaciones validar = new Validaciones();

            if (string.IsNullOrWhiteSpace(cboBox.Text))
            {
                btn.Enabled = true;
                cboBox.DropDownStyle = ComboBoxStyle.DropDown;

                if (articulo != null)
                {
                    if(prop == "Marca")
                        cboBox.SelectedValue = articulo.Marca.Id;
                    else if(prop == "Categoria")
                        cboBox.SelectedValue = articulo.Categoria.Id;
                }
                else { cboBox.SelectedIndex = 0; }
            }
            else
            {
                texto = cboBox.Text;
                bool contieneLetra = Regex.IsMatch(texto, @"^(?=.*[a-zA-Z]).*$");

                if (validar.caracteresEnRango(texto, 2, 50) && validar.cantidadDePalabras(texto) < 6 && contieneLetra)
                {
                    string textoFormateado = primerasLetrasMayusculas(texto, false);
                    int index = cboBox.FindStringExact(textoFormateado.Trim());
                    if (index >= 0)
                    {
                        cboBox.DropDownStyle = ComboBoxStyle.DropDown;
                        cboBox.SelectedIndex = index;
                    }
                    else
                    {
                        btn.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Input no válido: cantidad/tipos de caracteres y/o palabras incorrectos", "Error en " + cboBox.Name.Substring(3), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboBox.BackColor= Color.IndianRed;
                }
            }
        }

    }
}
