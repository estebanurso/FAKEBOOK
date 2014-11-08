using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAKEMODELO
{
    public class Publicaciones
    {
        private Usuario User;
        private int id;
        private string imágen;
        private string publicacion;
        private string fechadepublicacion;
        List<Comentario> ListaDeComentarios;


        public Usuario User1
        {
            get { return User; }
            set { User = value; }
        }
        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public string Imágen
        {
            get { return imágen; }
            set { imágen = value; }
        }
        

        public string Publicacion
        {
            get { return publicacion; }
            set { publicacion = value; }
        }
        

        public string Fechadepublicacion
        {
            get { return fechadepublicacion; }
            set { fechadepublicacion = value; }
        }
        

        public List<Comentario> ListaDeComentarios1
        {
            get { return ListaDeComentarios; }
            set { ListaDeComentarios = value; }
        }



        public Publicaciones(Usuario user, string publica, string fecha)
        {
            User1 = user;
            Publicacion = publica;
            Fechadepublicacion = fecha;
            ListaDeComentarios = new List<Comentario>();
            Id = 0;
        }

        public Publicaciones(Usuario user, string publica, string img, string fecha)
        {

            User1 = user;
            Publicacion = publica;
            Fechadepublicacion = fecha;
            Imágen = img;
            ListaDeComentarios = new List<Comentario>();
            Id = 0;
        }


        public Publicaciones()
        {
            Fechadepublicacion = "";
            User1 = null;
            Publicacion = "";
            Imágen = "";
            Id = 0;
            ListaDeComentarios = new List<Comentario>();
        
        }







    }
}