using Backend;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Negocio.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace escuele
{
    public partial class Z : Form
    {
        private Alumno alumno = new Alumno();
        private Asistencias asistencias = new Asistencias();
        private NegAlumno negalumno = new NegAlumno();
        private NegAsistencia neg = new NegAsistencia();
        DataSet ds = new DataSet();
        public DataTable DT { get; set; } = new DataTable();
        public Z()
        {
            InitializeComponent();

            dataGrid.ColumnCount = 3;
            dataGrid.Columns[0].HeaderText = "DNI";
            dataGrid.Columns[1].HeaderText = "nombre";
            dataGrid.Columns[0].Width = 100;
            dataGrid.Columns[1].Width = 100;
            dataGrid.Columns[2].HeaderText = "apellido";

            dataGrid.Columns[2].Width = 70;

            dataasistencia.ColumnCount = 6;
            dataasistencia.Columns[0].HeaderText = "Codigo";
            dataasistencia.Columns[1].HeaderText = "Nombre";
            dataasistencia.Columns[2].HeaderText = "Apellido";
            dataasistencia.Columns[3].HeaderText = "DNI";
            dataasistencia.Columns[4].HeaderText = "Asistencia";
            dataasistencia.Columns[5].HeaderText = "Fecha";
            dataasistencia.Columns[0].Width = 100;
            dataasistencia.Columns[1].Width = 100;
            dataasistencia.Columns[2].Width = 100;
            dataasistencia.Columns[3].Width = 100;
            dataasistencia.Columns[4].Width = 100;
            dataasistencia.Columns[5].Width = 100;




            LlenarAlum();
            LlenarAsistencia();
        }
        private void LlenarAlum()
        {
            dataGrid.Rows.Clear();

            ds = negalumno.ListadoAlumno("Todos");


            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dataGrid.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2]);
                    lblMensaje.Text = "";
                }
            }
            else
            {
                lblMensaje.Text = "No hay Alumnos cargados en el sistema";
            }

        }
        private void LlenarAsistencia()
        {
            dataasistencia.Rows.Clear();

            ds = neg.ListadoAsistencia("Todos");


            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dataasistencia.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4], dr[5].ToString());
                    lblMensaje.Text = "";
                }
            }


        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Bt_cargar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            string cuil = Txt_DNI.Text.Trim();

            if (Txt_DNI.Text != "" && Txt_Nombre.Text != "" && Txt_Apellido.Text != "")
            {

                if (cuil.Length == 8 && cuil.All(char.IsDigit))
                {
                    ds = negalumno.ListadoAlumno(Txt_DNI.Text);


                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            MessageBox.Show("No se pudo grabar el Alumno en el sistema porque ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        CargarAlumno();
                        nGrabados = negalumno.abmAlumno("Alta", alumno);
                        if (nGrabados == -1)
                        {
                            MessageBox.Show("No se pudo grabar el Alumno en el sistema");
                        }
                        else
                        {
                            MessageBox.Show("Se pudo grabar el Alumno en el sistema con exito");
                            LlenarAlum();
                            LIMPIARPANTALLA();

                        }
                    }


                }
                else
                {
                    MessageBox.Show("Ingrese un DNI válido de 8 números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                MessageBox.Show("Faltan Datos");

            }

        }
        private void CargarAlumno()
        {


            alumno.dni = int.Parse(Txt_DNI.Text);
            alumno.nombre = Txt_Nombre.Text;
            alumno.Apellido = apellido.Text;

            //alumno.Fechasis = DateTime.Today;


        }
        private void cargarAsistencia()
        {
            asistencias.Nombres = Txt_Nombre.Text;
            asistencias.apellido = apellido.Text;
            asistencias.DNis= int.Parse(Txt_DNI.Text);
            asistencias.asistnecias= check.Checked;
            asistencias.fehas = Time.Value; 
        }
        private void cargarAsistencias()
        {
            asistencias.id = int.Parse(Txt_Codigo.Text);
            asistencias.Nombres = Txt_Nombre.Text;
            asistencias.apellido = apellido.Text;
            asistencias.DNis = int.Parse(Txt_DNI.Text);
            asistencias.asistnecias = check.Checked;
            asistencias.fehas = Time.Value;
        }

        private void Bt_Borrar_Click(object sender, EventArgs e)
        {

            string DATO = Txt_DNI.Text;
            if (DATO != "")
            {
                ds = neg.ListadoAsistencia(Txt_DNI.Text);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        MessageBox.Show("no se pudo borrar el Alumno porque existe un pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    alumno.dni = Convert.ToInt32(Txt_DNI.Text);

                    negalumno.abmAlumno("Borrar", alumno);

                    MessageBox.Show("Se pudo borrar el Alumno ");
                    LlenarAlum();
                    LIMPIARPANTALLA();

                }


            }
        }

        private void Bt_Modificar_Click(object sender, EventArgs e)
        {
            int nResultado = -1;

            //if (validacion == true)
            //	{
            CargarAlumno();
            nResultado = negalumno.abmAlumno("Modificar", alumno);
            if (nResultado != -1)
            {
                MessageBox.Show("El alumno fue modificado con exito");
                LlenarAlum();
                LIMPIARPANTALLA();

            }
            else
            {
                MessageBox.Show("ERROR no se pudo modificar el alumno");
            }
        }
        private void LIMPIARPANTALLA()
        {
            apellido.Text = "";
            Txt_DNI.Text = "";
            Txt_Nombre.Text = "";
            Txt_Codigo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ds = negalumno.ListadoAlumno(Txt_DNI.Text);


            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Txt_Nombre.Text = dr["Nombre"].ToString();
                    Txt_DNI.Text = dr["DNI"].ToString();
                    apellido.Text = dr["apellido"].ToString();
                }
            }
            else
            {
                lblMensaje.Text = "No hay Alumnos cargados en el sistema";
            }
        }

        private void Bt_Cargar_Asis_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            string cuil = Txt_DNI.Text.Trim();

            if (Txt_DNI.Text != "" && Txt_Nombre.Text != "" && Txt_Apellido.Text != "")
            {

                if (cuil.Length == 8 && cuil.All(char.IsDigit))
                {
                    ds = negalumno.ListadoAlumno(Txt_DNI.Text);


                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            cargarAsistencia();
                            nGrabados = neg.abmAsistencia("Alta", asistencias);
                            if (nGrabados == -1)
                            {
                                MessageBox.Show("No se pudo grabar el Alumno en el sistema");
                            }
                            else
                            {
                                MessageBox.Show("Se pudo grabar el Alumno en el sistema con exito");
                                LlenarAsistencia();
                                LIMPIARPANTALLA();

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El alumno ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                   

                }
                else
                {
                    MessageBox.Show("Ingrese un DNI válido de 8 números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Bt_Borrar_Asis_Click(object sender, EventArgs e)
        {
            string DATO = Txt_Codigo.Text;
            if (DATO != "")
            {
                asistencias.id = Convert.ToInt32(Txt_Codigo.Text);






                neg.abmAsistencia("Borrar", asistencias);

                MessageBox.Show("Se pudo borrar la asistencia ");
                LlenarAsistencia();
                LIMPIARPANTALLA();


            }
        }

        private void Bt_Modificar_Asis_Click(object sender, EventArgs e)
        {
            int nResultado = -1;

            //if (validacion == true)
            //	{
            cargarAsistencias();
            nResultado = neg.abmAsistencia("Modificar", asistencias);
            if (nResultado != -1)
            {
                MessageBox.Show("la asistencia fue modificado con exito");
                LlenarAsistencia();
                LIMPIARPANTALLA();

            }
            else
            {
                MessageBox.Show("ERROR no se pudo modificar la asistencia");
            }
        }
        private void CrearReportePdf(DataGridView dataGridView, string outputPath)
        {
            PdfWriter writer = new PdfWriter(outputPath);
            PdfDocument pdf = new PdfDocument(writer);
            Document doc = new Document(pdf);

            // Crea la tabla con las columnas que tenga el dataGridView
            iText.Layout.Element.Table pdfTable = new iText.Layout.Element.Table(dataGridView.Columns.Count);

            // Añade titulos
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                pdfTable.AddCell(new Cell().Add(new Paragraph(column.HeaderText)));
            }


            // Añade los datos del DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Valida si es nulo
                    if (cell != null && cell.Value != null)
                    {
                        pdfTable.AddCell(new Cell().Add(new Paragraph(cell.Value.ToString())));
                    }
                    else
                    {
                        // En caso de que sea null
                        pdfTable.AddCell(new Cell().Add(new Paragraph("")));
                    }
                }
            }

            pdfTable.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
            // Añade la tabla al documento
            doc.Add(pdfTable);

            doc.Close();
        }
        private void Bt_Report_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Descargas|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;
                CrearReportePdf(dataasistencia, outputPath);
                MessageBox.Show("Reporte generado exitosamente!");
            }
        }
    }
}
