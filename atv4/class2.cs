usando  Sistema ;
usando  Sistema . Coleções . Genérico ;
usando  Sistema . Linq ;
usando  Sistema . Texto ;
usando  Sistema . Enfiando . Tarefas ;

namespace  _4aATV
{
     classe  Funcionário
   {
         string  public nome { get ; definir ; }
        public  int  matricula { get ; definir ; }
        public  int  salario { get ; definir ; }
    
        public  void  imprime ()
        {
            Consola . WriteLine ( this . nome  +  " \n Matrícula : "  +  this . matrícula  +  " \n Salario : "  +  this . salario );
        }
    }
}