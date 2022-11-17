usando  Sistema ;
usando  Sistema . Coleções . Genérico ;
usando  Sistema . Linq ;
usando  Sistema . Texto ;
usando  Sistema . Enfiando . Tarefas ;

namespace  ATV03
{
     classe  interna Aluno
    {
         nome da string  privada ;
     matrícula privada int  ;
     e- mail de string  pública ;

    public  Aluno ( string  nome )
    {
        isso . nome  =  nome ;
    }

     Aluno público ()
    {
    }

    public  Aluno ( string  nome , int  matrícula , string  email )
    {
        isso . nome  =  nome ;
        isso . matricula  =  matricula ;
        isso . e- mail  = e-  mail ;
    }


    // obtém e define o nome
     string  pública getNome ()
    {
        devolva  isso . nome ;
    }

    public  void  setNome ( string  nome )
    {
        isso . nome  =  nome ;
    }

    // obtém e define matrícula
    public  int  getMatricula ()
    {
        devolva  isso . matricula ;
    }

    public  void  setMatricula ( int  matrícula )
    {
        isso . matricula  =  matricula ;
    }

    // obtém e define o e-mail
     string  pública getEmail ()
    {
        devolva  isso . e-mail ;
    }

    public  void  setEmail ( string  email )
    {
        isso . nome  =  e-mail ;
    }

    public  void  imprimir ()
    {
        Consola . WriteLine ( this . nome  +  "  "  +  this . matrícula  +  "  "  +  this . email );
    }


}