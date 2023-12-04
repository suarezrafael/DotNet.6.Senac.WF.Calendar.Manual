namespace Senac.WF.Calendar.Manual
{
    public class Compromisso
    {
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Detalhes { get; set; }

        public Compromisso(DateTime data, string titulo, string detalhes)
        {
            Data = data;
            Titulo = titulo;
            Detalhes = detalhes;
        }
    }

    public partial class Form1 : Form
    {
        private TableLayoutPanel calendarPanel;
        private DateTime mesCorrente;
        private List<Compromisso> compromissos;

        public Form1()
        {
            InitializeComponent();

            // Configura��o inicial
            mesCorrente = DateTime.Now;
            label1.Text = mesCorrente.Month.ToString() + " / " + mesCorrente.Year.ToString();
            compromissos = new List<Compromisso>
            {
new Compromisso(DateTime.Now.AddDays(5), "Compromisso 1", "Detalhes do Compromisso 1"),
                new Compromisso(DateTime.Now.AddDays(10), "Compromisso 2", "Detalhes do Compromisso 2"),
                new Compromisso(DateTime.Now.AddDays(15), "Compromisso 3", "Detalhes do Compromisso 3"),
                new Compromisso(DateTime.Now.AddDays(15), "Compromisso 4", "Detalhes do Compromisso 4"),

            };

            MontarCalendario();
        }

        private void MontarCalendario()
        {
            // Limpa o painel antes de renderizar novamente
            calendarPanel?.Dispose();

            // Cria um novo painel para o calend�rio
            calendarPanel = new TableLayoutPanel
            {
                // espicha pra largura do panel1
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                RowCount = 6,
                ColumnCount = 7
            };


            // Cria sub-pain�is para cada dia do m�s
            DateTime startDate = new DateTime(mesCorrente.Year, mesCorrente.Month, 1);
            int diasDoMes = DateTime.DaysInMonth(mesCorrente.Year, mesCorrente.Month);
            int currentRow = 0, currentCol = (int)startDate.DayOfWeek;

            for (int dia = 1; dia <= diasDoMes; dia++)
            {
                // Cria sub-painel para o dia
                Panel painelDia = new Panel
                {
                    Dock = DockStyle.Fill,
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Adiciona um TextBox ao sub-painel para exibir o dia do m�s
                TextBox dayTextBox = new TextBox
                {
                    Text = dia.ToString(),
                    Dock = DockStyle.Top,
                    TextAlign = HorizontalAlignment.Center,
                    ReadOnly = true,
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.White
                };

                painelDia.Controls.Add(dayTextBox);

                // Adiciona compromissos ao sub-painel
                var compromissosDoDia = compromissos.Where(c => c.Data.Day == dia && 
                                                 c.Data.Month == mesCorrente.Month &&
                                                 c.Data.Year == mesCorrente.Year).ToList();
                foreach (var compromisso in compromissosDoDia)
                {
                    Label compromissoLabel = new Label
                    {
                        Text = compromisso.Titulo,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Height = 20,
                        ForeColor = Color.Blue
                    }; 
                    
                    compromissoLabel.Click += (sender, e) => MostrarDetalhesCompromisso(compromisso);

                    painelDia.Controls.Add(compromissoLabel);
                }

                // Adiciona o sub-painel ao painel do calend�rio
                calendarPanel.Controls.Add(painelDia, currentCol, currentRow);

                // Atualiza as posi��es da linha e coluna
                currentCol++;
                if (currentCol == 7)
                {
                    currentCol = 0;
                    currentRow++;
                }
            }
            panel1.Controls.Add(calendarPanel);
        }

        private void MostrarDetalhesCompromisso(Compromisso compromisso)
        {
            // Cria e exibe um formul�rio com detalhes do compromisso
            Form detalhesForm = new Form
            {
                Text = $"Detalhes do Compromisso: {compromisso.Titulo}",
                Size = new Size(300, 200),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label detalhesLabel = new Label
            {
                Text = compromisso.Detalhes,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            detalhesForm.Controls.Add(detalhesLabel);
            detalhesForm.ShowDialog();
        }

        private void btnPrevMonth_Click_1(object sender, EventArgs e)
        {
            // Retrocede para o m�s anterior e renderiza o calend�rio novamente
            mesCorrente = mesCorrente.AddMonths(-1);
            label1.Text = mesCorrente.Month.ToString() + " / " + mesCorrente.Year.ToString();
            MontarCalendario();
        }

        private void btnNextMonth_Click_1(object sender, EventArgs e)
        {
            // Avan�a para o pr�ximo m�s e renderiza o calend�rio novamente
            mesCorrente = mesCorrente.AddMonths(1);
            label1.Text = mesCorrente.Month.ToString() + " / " + mesCorrente.Year.ToString();
            MontarCalendario();
        }
    }
}
