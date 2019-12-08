using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;

        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                    CriarNoticias();
                return noticias;
            }
        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();
            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "João Carlos",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut a nunc ut erat placerat iaculis. Integer eget mi id nibh scelerisque tincidunt. Morbi sollicitudin, urna et vehicula fringilla, est augue iaculis purus, ac euismod neque nisl sit amet metus. Nulla sit amet dui vel diam auctor efficitur non nec lorem. In tempor, est eu mattis pellentesque, ipsum lectus aliquet lacus, non dignissim risus justo finibus enim. Phasellus commodo odio eget dolor dictum tempor. Nullam nec mattis lorem."
            });
            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "Cras in cursus purus",
                Autor = "João Carlos",
                Data = DateTime.Today.AddDays(-5),
                Conteudo = "Cras in cursus purus. Nulla rutrum viverra viverra. Pellentesque nec massa mi. Ut posuere hendrerit malesuada. Morbi pulvinar tincidunt pulvinar. Sed sit amet metus ullamcorper, consequat lacus et, gravida erat. Proin interdum elementum pharetra. Fusce tincidunt, lorem at tempus sollicitudin, dui sem elementum est, ac aliquam odio augue eu diam. Integer a ullamcorper magna."
            });
            noticias.Add(new Noticia
            {
                Id = 3,
                Titulo = "Nam varius nulla nec risus commodo sodales",
                Autor = "Carla Soares",
                Data = DateTime.Today,
                Conteudo = "Nam varius nulla nec risus commodo sodales. Nunc sed rhoncus nibh. Vestibulum congue eu orci eu imperdiet. Quisque fermentum libero a velit venenatis, sed porttitor nunc venenatis. Curabitur quam leo, maximus quis orci quis, tristique scelerisque lacus. Proin in augue arcu. Vivamus accumsan quis augue ut auctor. Suspendisse ornare mauris urna, ut placerat odio ullamcorper vel. Nulla convallis et lectus eget efficitur. Suspendisse vel odio lacinia, porta ligula in, dictum metus."
            });
            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "Quisque a tellus tempus, egestas urna ut, posuere velit",
                Autor = "Maria Cardoso",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "Quisque a tellus tempus, egestas urna ut, posuere velit. Sed nec est id ligula luctus feugiat ut et sem. Nam ullamcorper fringilla egestas. Phasellus pharetra feugiat volutpat. Curabitur id orci pellentesque, blandit justo at, porta enim. Sed eu tincidunt justo. In eget ante vitae massa imperdiet lobortis. Nam a maximus sem, non placerat risus. Nullam volutpat ex sed porta porttitor. Aliquam condimentum pharetra massa vitae vestibulum. Nullam vitae congue massa. Nunc in risus lacus. Sed in euismod mauris."
            });
            noticias.Add(new Noticia
            {
                Id = 5,
                Titulo = "Donec id velit id nulla pharetra blandit et eu leo. Aliquam erat volutpat",
                Autor = "Antonio Pereira",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "Donec id velit id nulla pharetra blandit et eu leo. Aliquam erat volutpat. Maecenas quis lacus vel nulla tempor volutpat vel a ex. Donec consectetur fermentum turpis, a fermentum nisi consectetur et. Curabitur eget tellus et justo facilisis molestie non sit amet neque. Mauris mauris odio, pretium sit amet lacinia sit amet, lacinia ut mauris. Etiam lacinia venenatis est, sit amet ultricies dolor dapibus at. Nulla ex ante, fringilla vel pharetra eu, malesuada vel ligula. Curabitur iaculis dolor eget metus blandit dignissim sed eget sem. Proin semper augue ac magna finibus molestie. Aliquam mollis sapien nisi, placerat congue magna accumsan nec. Integer nec lectus vehicula, laoreet nisl quis, aliquam libero. Sed eget elit erat. Integer tristique in erat quis tempus. Sed gravida turpis nulla, quis malesuada nisl sagittis vel. Praesent odio nunc, porttitor non massa et, hendrerit ornare ante."
            });
        }
    }
}