namespace Colletta_internazionale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Lista = new Dictionary<Partecipante, Importo>();           
            somma = 0;
            goal = 1000.00;
            buttonTotale.Text = "Obiettivo: " + goal.ToString();
        }
        private Dictionary<Partecipante, Importo> Lista;
        private double somma;
        private double goal;

        private void Form1_Load(object sender, EventArgs e)
        {
            listView.Columns.Add("Nome   ");
            listView.Columns.Add("Importo");
            listView.Columns.Add("Valuta ");    
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            string nome, valuta;
            double importo = -1;
            Importo i;
            Partecipante p;
            try
            {
                nome = textBoxNome.Text;
                valuta = textBoxValuta.Text;
                importo = Convert.ToDouble(textBoxImporto.Text);
                i = new Importo(importo, valuta);
                p = new Partecipante(nome);
            } 
            catch(Exception) { MessageBox.Show("Parametri invalidi"); return; }

            if (Lista.ContainsKey(p))
            { }
            else
            {
                somma += importo;
                button4.Text = somma.ToString();
                Lista.Add(p, i);
                string[] str = new string[] { nome, importo.ToString(), valuta };
                ListViewItem riga = new (str);
                listView.Items.Add(riga);
            }
            if (somma > goal)
                MessageBox.Show("Obiettivo raggiunto!");
        }

        private void buttonCercaimporto_Click(object sender, EventArgs e)
        {
            double imp = 0;
            string vl = "€";
            Importo i = new (0, vl);
            try { 
                imp = Convert.ToDouble(textBoxImporto.Text);                
                vl = textBoxValuta.Text;
                i = new Importo(imp, vl);
            }
            catch (Exception) { MessageBox.Show("Importo invalido"); }
            
            if (Lista.ContainsValue(i)) 
            {
                int c = 0;
                foreach(KeyValuePair < Partecipante, Importo > a in Lista)
                { 
                    if(a.Value.Valore == imp && a.Value.Valuta == vl)
                    {
                        c++;
                    }
                }
                MessageBox.Show(c + " persona/e ha/hanno versato questo importo");             
            }
            else MessageBox.Show("Nessuno ha versato questo importo");
            
        }

        private void buttonOrdinaimporto_Click(object sender, EventArgs e)
        {
            Dictionary<Partecipante, Importo> tmp = new Dictionary<Partecipante, Importo>();

            foreach (KeyValuePair<Partecipante, Importo> val in Lista.OrderByDescending(x => x.Value.ValoreReale()))
            {
                tmp[val.Key] = val.Value;
            }
            Lista = new Dictionary<Partecipante, Importo>(tmp);
            RefreshListView();
        }
        
        private void buttonOrdinanome_Click(object sender, EventArgs e)
        {
            SortedDictionary<Partecipante, Importo> s = new (Lista);
            RefreshListView(s);
        }
        private void RefreshListView(SortedDictionary<Partecipante, Importo> tabella)
        {
            listView.Clear();
            listView.Columns.Add("Nome   ");
            listView.Columns.Add("Importo");
            listView.Columns.Add("Valuta ");
            ListViewItem riga = new ListViewItem();
            string[] str = new string[3];
            foreach (KeyValuePair<Partecipante, Importo> rig in tabella) 
            {
                str[0] = rig.Key.Nome;
                str[1] = rig.Value.Valore+"";
                str[2] = rig.Value.Valuta;
                riga = new ListViewItem(str);
                listView.Items.Add(riga);
            }
        }
        private void RefreshListView()
        {
            listView.Clear();
            listView.Columns.Add("Nome   ");
            listView.Columns.Add("Importo");
            listView.Columns.Add("Valuta ");
            ListViewItem riga = new ListViewItem();
            string[] str = new string[3];
            foreach (KeyValuePair<Partecipante, Importo> rig in Lista)
            {
                str[0] = rig.Key.Nome;
                str[1] = rig.Value.Valore + "";
                str[2] = rig.Value.Valuta;
                riga = new ListViewItem(str);
                listView.Items.Add(riga);
            }
        }

        private void buttonCercaNome_Click(object sender, EventArgs e)
        {
            string nome = "sample";
            double sum = 0;
            Partecipante p = new Partecipante(nome);
            try
            {
                nome = textBoxNome.Text;
                p = new Partecipante(nome);
            }
            catch (Exception) { MessageBox.Show("Partecipante invalido"); }
            foreach (KeyValuePair<Partecipante, Importo> a in Lista)
            {
                if (a.Key.Nome == nome)
                {
                    sum += a.Value.ValoreReale();
                }
            }
            if (sum > 0)
            {
                MessageBox.Show(nome + " ha versato " + sum.ToString() + '€');                           
            }
            else MessageBox.Show("Nessuno chiamato così ha versato importi");
        }

        private void buttonTotale_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}