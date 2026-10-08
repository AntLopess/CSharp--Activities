using System.Drawing.Text;

namespace PetShopForms
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        private List<Animal> _animais = new List<Animal>();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            if (!int.TryParse(txtIdade.Text, out int idade))
            {
                MessageBox.Show("Digite uma idade válida.", "Erro de validação");
                return;
            }

            Animal novoAnimal;

            try
            {
                if (cmbTipo.SelectedItem?.ToString() == "Cachorro")
                    novoAnimal = new Cachorro(nome, idade);
                else if (cmbTipo.SelectedItem?.ToString() == "Gato")
                    novoAnimal = new Gato(nome, idade);
                else if (cmbTipo.SelectedItem?.ToString() == "Passaro")
                    novoAnimal = new Passaro(nome, idade);
                else
                {
                    MessageBox.Show("Selecione o tipo do animal.", "Erro de validação");
                    return;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro ao cadastrar");
                return;
            }

            _animais.Add(novoAnimal);
            lstAnimais.Items.Add(novoAnimal);

            AtualizarQuantidade();

            txtNome.Clear();
            txtIdade.Clear();
            cmbTipo.SelectedIndex = -1;

        }

        private void btnFazerSom_Click(object sender, EventArgs e)
        {
            if (lstAnimais.SelectedItem is Animal animalSelecionado)
            {
                MessageBox.Show(animalSelecionado.FazerSom(), $"{animalSelecionado.Nome} diz:");
            }
            else
            {
                MessageBox.Show("Selecione um animal da lista primeiro.", "Nenhum animal selecionado");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstAnimais.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um animal para remover.", "Aviso");
                return;
            }

            int indice = lstAnimais.SelectedIndex;

            _animais.RemoveAt(indice);
            lstAnimais.Items.RemoveAt(indice);

            AtualizarQuantidade();
        }

        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void lstAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AtualizarQuantidade()
        {
            lblQuantidade.Text = $"Animais cadastrados: {_animais.Count}";
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
