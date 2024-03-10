using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.Metrics;
using MudBlazor.Services;
using DWIS.Vocabulary.Development;
using DWIS.Vocabulary.Controls;
using RDFSharp.Model;
using System.Text;
using System.IO;

namespace DWIS.Vocabulary.InstanceEdition
{
    public partial class InstanceEditionForm : Form
    {
        private DWISInstance dWISInstance;
        private DWISVocabulary vocabulary = Standard.VocabularyProvider.GetDWISVocabulary();
        public InstanceEditionForm()
        {
            InitializeComponent();
            dWISInstance = new Development.DWISInstance("Rig instance", vocabulary);

            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            services.AddMudServices();
            services.AddMermaidJS();
            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();

            dWISInstance.Population = new SimplePopulation();
            dWISInstance.ClassAssertions = new SimpleClassAssertionCollection();
            dWISInstance.Sentences = new SimpleSentenceCollection();
            dWISInstance.ImplicitSentences = new SimpleImplicitSentenceCollection();
            //dWISInstance.
            blazorWebView1.RootComponents.Add<DWIS.Vocabulary.Controls.InstanceEdition>("#app",
                   new Dictionary<string, object>
                   {
                        { nameof(DWIS.Vocabulary.Controls.InstanceEdition.Vocabulary), vocabulary },
                        { nameof(DWIS.Vocabulary.Controls.InstanceEdition.DWISInstance), dWISInstance },
                        { nameof(DWIS.Vocabulary.Controls.InstanceEdition.ShowNouns), true}
                   }
               );

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copyMermaidCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mermaid = DWISMermaidDiagram.GetDiagramCode(dWISInstance);
            Clipboard.SetText(mermaid);
        }

        private void copyOWL()
        {
            var ontology = Standard.OntologyProvider.GetDWISOntology();
            ontology = DWIS.Vocabulary.OWL.OntologyGeneration.AddInstance(ontology, vocabulary, dWISInstance);
            var tempFile = System.IO.Path.GetTempFileName();
                      
                ontology.ToRDFGraph().ToFile(RDFModelEnums.RDFFormats.Turtle, tempFile);

            Clipboard.SetText(System.IO.File.ReadAllText(tempFile));
        }

        private void copyTurtleCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyOWL();
        }
    }
}
