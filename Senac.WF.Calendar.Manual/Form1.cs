namespace Senac.WF.Calendar.Manual
{
    public partial class Form1 : Form
    {
        private TableLayoutPanel calendarPanel;
        private DateTime currentMonth;

        public Form1()
        {
            InitializeComponent();

            // Configuração inicial
            currentMonth = DateTime.Now;
            RenderCalendar();
        }

        private void RenderCalendar()
        {
            // Limpa o painel antes de renderizar novamente
            calendarPanel?.Dispose();

            // Cria um novo painel para o calendário
            calendarPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                RowCount = 6,
                ColumnCount = 7
            };

           

            // Cria sub-painéis para cada dia do mês
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

                // Adiciona um TextBox ao sub-painel para exibir o dia do mês
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

                // Adiciona o sub-painel ao painel do calendário
                calendarPanel.Controls.Add(dayPanel, currentCol, currentRow);

                // Atualiza as posições da linha e coluna
                currentCol++;
                if (currentCol == 7)
                {
                    currentCol = 0;
                    currentRow++;
                }
            }
            // Adiciona o painel do calendário ao formulário

            panel1.Controls.Add(calendarPanel);
        }



        private void btnPrevMonth_Click_1(object sender, EventArgs e)
        {
            // Retrocede para o mês anterior e renderiza o calendário novamente
            currentMonth = currentMonth.AddMonths(-1);
            RenderCalendar();
        }

        private void btnNextMonth_Click_1(object sender, EventArgs e)
        {
            // Avança para o próximo mês e renderiza o calendário novamente
            currentMonth = currentMonth.AddMonths(1);
            RenderCalendar();
        }
    }
}
