using InjecaoDependenciaWinForms.Services;

namespace InjecaoDependenciaWinForms
{
    public partial class Form1 : Form
    {
        private readonly IMessageService _messageService;

        public Form1(IMessageService messageService)
        {
            _messageService = messageService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = _messageService.GetMessage();
        }
    }
}
