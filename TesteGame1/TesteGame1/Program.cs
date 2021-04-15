using System;

namespace TesteGame1 {
    class Program {
        static void Main() {

            Random random = new Random();
            int espada;
            int defesaMonstro = 5;
            int danoPlayer;
            int defesaPlayer = 5;
            int danoMonstro;
            int cura;
            int vidaJogador = 100;
            int vidaJogadorRestante = 100;
            int vidaMonstroTotal = 50;
            int vidaMonstroRestante = 50;
            bool acerto;
            bool fim = false;

            do {
                Console.WriteLine("O que deseja fazer? Atacar, Curar, Fugir?");
                string comando = Console.ReadLine();

                Console.Clear();

                switch (comando) {

                    case "Atacar":

                        espada = random.Next(1, 16);
                        acerto = espada > defesaMonstro ? true : false;
                        if (acerto) {
                            danoPlayer = espada - defesaMonstro;
                            vidaMonstroRestante -= danoPlayer;
                            Console.WriteLine("HAZAAAAA o golpe acertou, causando {0} de dano no inimigo!", danoPlayer);
                        } else {
                            Console.WriteLine("wushhh o ataque passa longe, tu errou!");
                        }
                        Console.WriteLine("O inimigo ainda tem {0} de vida!", vidaMonstroRestante);
                        break;

                    case "Curar":
                        cura = random.Next(1, 11);
                        vidaJogadorRestante += cura;
                        if (vidaJogadorRestante >= vidaJogador) {
                            vidaJogadorRestante = vidaJogador;
                        }
                        Console.WriteLine("A magia te curou {0}, sua vida agora é {1}", cura, vidaJogadorRestante);
                        break;

                    case "Fugir":
                        Console.WriteLine("COVARDE!");
                        fim = true;
                        break;
                }
                if (vidaMonstroRestante <= 0) {
                    Console.WriteLine("O inimigou morreu, parabéns!");
                    fim = true;
                } else {

                    danoMonstro = random.Next(1, 21);
                    acerto = danoMonstro > defesaPlayer ? true : false;

                    if (acerto) {
                        danoMonstro = danoMonstro - defesaPlayer;
                        vidaJogadorRestante -= danoMonstro;
                        Console.WriteLine("Oh não, o monstro lhe causou dano de {0}, tu ainda tens {1} de vida!", danoMonstro, vidaJogadorRestante);
                    } else {
                        Console.WriteLine("O monstro errou!");
                    }
                }
            } while (!fim);
        }
    }
}
