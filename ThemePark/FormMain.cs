namespace ThemePark
{
    public partial class FormMain : Form
    {
        int m_ticket = 10;
        // Start sim with $0
        int m_totalCashOnHand = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            // We can say tickets are $10
            // Every time someone buys a ticket our label of cash should
            // increase by the ticket price.
            // Buy A ticket
            m_totalCashOnHand = m_totalCashOnHand + m_ticket;
            // Let's display the cash on hand variable in the label
            labelTotalCash.Text = m_totalCashOnHand.ToString();           
        }
    }
}
