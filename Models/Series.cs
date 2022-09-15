namespace TP8_Series
{

    public class Series
    {
        private int _idSerie;
        private string _nombreSerie;
        private int _añoInicio;
        private string _sinopsis;
        private string _imagenSerie;


        public Series(int idSerie, string nombreSerie, int añoInicio, string sinopsis, string imagenSerie)
        {
            _idSerie = idSerie;
            _nombreSerie = nombreSerie;
            _añoInicio = añoInicio;
            _sinopsis = sinopsis;
            _imagenSerie = imagenSerie;
        }

        public Series()
        {

        }

        public int idSerie
        {
            get{return _idSerie;}
            set{_idSerie = value;}
        }

        public string nombreSerie
        {
            get{return _nombreSerie;}
            set{_nombreSerie = value;}
        }

        public int añoInicio
        {
            get{return _añoInicio;}
            set{_añoInicio = value;}
        }

        public string sinopsis
        {
            get{return _sinopsis;}
            set{_sinopsis = value;}
        }

        public string imagenSerie
        {
            get{return _imagenSerie;}
            set{_imagenSerie = value;}
        }






    }



















}