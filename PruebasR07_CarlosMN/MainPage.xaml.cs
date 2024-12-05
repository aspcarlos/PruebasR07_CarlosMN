using BRelacion07_CarlosMN;
namespace PruebasR07_CarlosMN
{
    public partial class MainPage : ContentPage
    {
        //MIEMBROS PRIVADOS
        ViewMatricula matricula;
        ViewMayorEdad mayorEdad;


        public MainPage()
        {
            InitializeComponent();

            matricula = new ViewMatricula();
            mayorEdad = new ViewMayorEdad();

            contenedorPrincipal.Children.Add(matricula);
            contenedorPrincipal.Children.Add(mayorEdad);


            Content = contenedorPrincipal;
        }


    }

}
