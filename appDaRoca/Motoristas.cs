using apDaRoca;
using System.Collections.Generic;

public class Motoristas
{

    private string idMotorista;
    private string idCentro;
    private string nome;
    private string horaInicio;
    private string horaFim;
    private string inicioIntervalo;
    private string fimIntervalo;
    private List<Pedidos> pedidos;
    private List<string> rota;

    public Motoristas()
    {
        Pedidos = new List<Pedidos>();
        Rota = new List<string>();
    }

    public Motoristas(string idMotorista, string idCentro, string nome, string horaInicio, string horaFim, string inicioIntervalo, string fimIntervalo, List<Pedidos> pedidos)
    {
        this.idMotorista = idMotorista;
        this.idCentro = idCentro;
        this.nome = nome;
        this.horaInicio = horaInicio;
        this.horaFim = horaFim;
        this.inicioIntervalo = inicioIntervalo;
        this.fimIntervalo = fimIntervalo;
        this.pedidos = new List<Pedidos>();
    }



    public string InicioIntervalo { get => inicioIntervalo; }
    public string FimIntervalo { get => fimIntervalo; }

    public string IdMotorista { get => idMotorista; set => idMotorista = value; }
    public string Nome { get => nome; set => nome = value; }
    public string IdCentro { get => idCentro; set => idCentro = value; }
    public List<Pedidos> Pedidos { get => pedidos; set => pedidos = value; }
    public List<string> Rota { get => rota; set => rota = value; }
    public string HoraInicio { get => horaInicio; set => horaInicio = value; }
    public string HoraFim { get => horaFim; set => horaFim = value; }

    public void AdicionarPedido(Pedidos pedido)
    {
        pedidos.Add(pedido);
    }
}

