namespace Senac.WF.Calendar.Manual
{
    public partial class Form1 : Form
    {
        private TableLayoutPanel calendarPanel;
        private DateTime currentMonth;

        public Form1()
        {
            InitializeComponent();

            // Configura��o inicial
            currentMonth = DateTime.Now;
            RenderCalendar();
        }

        private void RenderCalendar()
        {
            // Limpa o painel antes de renderizar novamente
            calendarPanel?.Dispose();

            // Cria um novo painel para o calend�rio
            calendarPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                RowCount = 6,
                ColumnCount = 7
            };

           

            // Cria sub-pain�is para cada dia do m�s
            DateTime startDate = new DateTime(currentMonth.Year, currentMonth.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month);
            int currentRow = 0, currentCol = (int)startDate.DayOfWeek;

            for (int day = 1; day <= daysInMonth; day++)
            {
                // Cria sub-painel para o dia
                Panel dayPanel = new Panel
                {
                    Dock = DockStyle.Fill,
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Adiciona um TextBox ao sub-painel para exibir o dia do m�s
                TextBox dayTextBox = new TextBox
                {
                    Text = day.ToString(),
                    Dock = DockStyle.Fill,
                    TextAlign = HorizontalAlignment.Center,
                    ReadOnly = true,
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.White
                };

                dayPanel.Controls.Add(dayTextBox);

                // Adiciona o sub-painel ao painel do calend�rio
                calendarPanel.Controls.Add(dayPanel, currentCol, currentRow);

                // Atualiza as posi��es da linha e coluna
                currentCol++;
                if (currentCol == 7)
                {
                    currentCol = 0;
                    currentRow++;
                }
            }
            // Adiciona o painel do calend�rio ao formul�rio

            panel1.Controls.Add(calendarPanel);
        }



        private void btnPrevMonth_Click_1(object sender, EventArgs e)
        {
            // Retrocede para o m�s anterior e renderiza o calend�rio novamente
            currentMonth = currentMonth.AddMonths(-1);
            RenderCalendar();
        }

        private void btnNextMonth_Click_1(object sender, EventArgs e)
        {
            // Avan�a para o pr�ximo m�s e renderiza o calend�rio novamente
            currentMonth = currentMonth.AddMonths(1);
            RenderCalendar();
        }
    }
}
