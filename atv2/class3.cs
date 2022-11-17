classe  Funcionário
{
     nome da string  privada ;
     matrícula privada int  ;
     salário flutuante  público ;

     funcionário público ( string nome ) 
    {
        isso . nome  =  nome ;
    }

     funcionário público ()
    {
    }

    public  Funcionário ( string  nome , int  matrícula , float  salario )
    {
        isso . nome  =  nome ;
        isso . matricula  =  matricula ;
        isso . salario  =  salario ;
    }

     string  pública getNome ()
    {
        devolva  isso . nome ;
    }

    public  void  setNome ( string  nome )
    {
        isso . nome  =  nome ;
    }

    public  int  getMatricula ()
    {
        devolva  isso . matricula ;
    }

    public  void  setMatricula ( int  matrícula )
    {
        isso . matricula  =  matricula ;
    }

    public  float  getSalario ()
    {
        devolva  isso . salario ;
    }

    public  void  setSalario ( float  salario )
    {
        isso . salario  =  salario ;
    }

    public  void  imprimir ()
    {
        Consola . WriteLine ( this . nome  +  & quot ; & quot ; + this . matricula  +  & quot ; & quot ; + this . salario );
    }

}