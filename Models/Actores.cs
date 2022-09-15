namespace TP8_Series
{

    public class Actores
    {
        private int _idActor;
        private int _idSerie;
        private string _nombreActor;

        public Actores(int idActor, int idSerie, string nombreActor)
        {
            _idActor = idActor;
            _idSerie = idSerie;
            _nombreActor = nombreActor;
        }

        public Actores(){

        }

        public int idActor
        {
            get{return _idActor;}
            set{_idActor = value;}
        }

        public int idSerie
        {
            get{return _idSerie;}
            set{_idSerie = value;}
        }

        public string nombreActor
        {
            get{return _nombreActor;}
            set{_nombreActor = value;}
        }

    }









}