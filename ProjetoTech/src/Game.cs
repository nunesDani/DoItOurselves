using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoTech.src.Entities;
using ProjetoTech;
using ProjetoTech.src;

namespace ProjetoTech.src.Entities
{
    public class Game
    {
        private string typeHero;
        private string nameHero;
        private static int stage;

        private Arqueira arqueira;
        private Cavaleira cavaleira;
        private Feiticeira feiticeira;
        private Lutadora lutadora;

        private Enemy inimigo = new Enemy();


        public void StartGame()
        {
            Prologue();
        }

        private void Prologue()
        {
            Console.WriteLine("--------PRÓLOGO--------\n\nEssa não!!");
            Console.WriteLine("\nVocê acordou e descobriu que um feiticeiro muito poderoso está tentando dominar o mundo, o Rei da Cocada Preta!");

            Console.ReadLine();

            Console.WriteLine("Ele enfeitiçou a todos e agora eles estão agindo de um jeito estranho... ");

            Console.ReadLine();

            Console.WriteLine("\nOs homens andam por aí com o peito estufado, exalando um ar de superioridade...");
            Console.ReadLine();
            Console.WriteLine("Já os que estão dentro de suas casas, apenas ficam no sofá assistindo TV...");
            Console.ReadLine();
            Console.WriteLine("E enquanto isso as mulheres cuidam de todas as tarefas domésticas como se fosse obrigação!");

            Console.ReadLine();

            Console.WriteLine("\nUma profecia antiga dizia que apenas uma pessoa seria imune ao feitiço...");
            Console.WriteLine("E quando esse dia chegasse, essa pessoa seria a escolhida para combater o Rei da Cocada-Preta, e trazer de volta a ordem e a paz.");

            Console.ReadLine();

            Console.WriteLine("\nE a escolhida é Você!");

            Console.ReadLine();
            Console.Clear();

            CreateHero();

        }

        private void CreateHero()
        {
            Console.WriteLine("Digite seu nome de guerreira: ");
            this.nameHero = Console.ReadLine();

            if (string.IsNullOrEmpty(this.nameHero))
            {
                Console.WriteLine("Nome não pode estar vazio! Tente novamente.\n");
                CreateHero();
            }

            Console.Clear();
            SelectClass();

        }

        private void SelectClass()
        {
            Console.WriteLine($"Olá {this.nameHero}! Como você quer combater O Rei da Cocada Preta?");
            Console.WriteLine("\n[1] - Cavaleira\n'Mostrarei a eles a justiça da minha lâmina!'");
            Console.WriteLine("\n[2] - Feiticeira\n'Vou combater magia com mais magia!'");
            Console.WriteLine("\n[3] - Arqueira\n'Ninguém escapará da minha mira!'");
            Console.WriteLine("\n[4] - Lutadora\n'Meus punhos colocarão juízo na cabeça deles!'");

            this.typeHero = Console.ReadLine();

            if (this.typeHero == "1")
            {
                this.cavaleira = new Cavaleira(this.nameHero);
            }

            else if (this.typeHero == "2")
            {
                this.feiticeira = new Feiticeira(this.nameHero);
            }

            else if (this.typeHero == "3")
            {
                this.arqueira = new Arqueira(this.nameHero);
            }

            else if (this.typeHero == "4")
            {
                this.lutadora = new Lutadora(this.nameHero);
            }

            else
            {
                Console.WriteLine("Opção inválida! Pressione [ENTER] para tentar mais uma vez.");
                Console.ReadLine();
                Console.Clear();
                SelectClass();
            }

            Console.Clear();
            FirstPhase();
        }

        private void FirstPhase() // VILAREJO
        {
            stage = 1;
            Console.Clear();
            Console.WriteLine($"\n{this.nameHero}, sua missão é sair do vilarejo, atravessar a floresta, chegar até a cidade, entrar no castelo e vencer o Rei da Cocada Preta em um duelo.");

            Console.WriteLine("\nPressione [ENTER] para sair de sua casa.");
            Console.ReadLine();

            Console.WriteLine("\nAo sair de casa, você fica pasma com o que encontra, seu vilarejo antes conhecido por ser um lugar alegre e unido, agora possui uma aparência 'preta e branca'.");
            Console.WriteLine("\nA placa de entrada do vilarejo foi pintada de vermelho, e há por cima escrito 'Macholândia'. ");

            Console.ReadLine();

            Console.WriteLine("\nTodos parecem diferentes do usual, as mulheres parecem sempre estar com muito medo de algo...");
            Console.WriteLine("\nJá os homens por outro lado, mostram ter coragem para tudo, inclusive para brigarem por motivo nenhum! É como se fosse alguma disputa sem sentido por poder.");

            Console.ReadLine();
            Console.WriteLine("\nEssa situação está toda errada, precisamos nos apressar antes que tudo piore!");

            Console.WriteLine("\nPressione [ENTER] para cruzar o vilarejo em direção à floresta.");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Caminhando...");
            Console.ReadLine();

            Console.WriteLine("No meio do caminho você se depara com uma cena horrível!");
            Console.ReadLine();

            Console.WriteLine("Uma mulher está sendo puxada pelo braço e mesmo repetindo 'não' diversas vezes, o homem não parece se importar.");
            Console.ReadLine();

            Console.WriteLine("\n[1] - Intervir de forma pacífica");
            Console.WriteLine("[2] - Intervir");

            var input = Console.ReadLine();

            while (input != "1" && input != "2")
            {
                Console.WriteLine("Opção inválida, tente novamente.");

                Console.WriteLine("\n[1] - Tentar intervir de forma pacífica");
                Console.WriteLine("[2] - Tentar intervir");

                input = Console.ReadLine();
            }


            if (input == "1")
            {
                Console.Clear();

                Console.WriteLine("Você se aproxima dos dois e questiona:");
                Console.WriteLine("- Com licença, você conhece esse homem?");

                Console.ReadLine();

                Console.WriteLine("A mulher nega com a cabeça.");
                Console.WriteLine("- Não! Não o conheço!");

                Console.ReadLine();

                Console.WriteLine("Você segura o braço do homem.");
                Console.WriteLine("- Então preciso que o senhor a solte por favor. Ela deixou claro que não te conhece e não tem o menor interesse em ir para qualquer lugar que seja com você.");

                Console.ReadLine();

                Console.WriteLine("Ele se vira para você e sorri.");
                Console.WriteLine("- Então que tal você vir se divertir comigo no lugar dela?");

                Console.ReadLine();

                Console.WriteLine("\nVocê percebe que isso será mais complicado do que você pensou...");

                Console.WriteLine("\nINICIANDO DUELO...");
                Console.ReadLine();

                Console.Clear();

                inimigo.SpawnEnemy("Homem Estranho");
                Duel();
            }

            else if (input == "2")
            {
                Console.Clear();

                Console.WriteLine("Você corre na direção deles e empurra o homem suspeito.");
                Console.WriteLine("- Ela disse que não quer!");

                Console.ReadLine();

                Console.WriteLine("O homem se volta para você com uma expressão enfurecedora.");
                Console.WriteLine("- E quem você pensa que é para me dizer o que fazer? Saia da frente antes que eu te machuque.");

                Console.ReadLine();

                Console.WriteLine("Você se posiciona entre os dois, protegendo a mulher que se encontra assustada.");

                Console.WriteLine("\nINICIANDO DUELO...");
                Console.ReadLine();

                Console.Clear();

                inimigo.SpawnEnemy("Homem Estranho");
                Duel();
            }

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("O homem já caído no chão, se levanta e vai embora.");
            Console.WriteLine("- Tsc... Eu vou- Ai! ...Deixar vocês se safarem dessa vez.");

            Console.ReadLine();

            Console.WriteLine("Você se vira para a moça e a conforta.");
            Console.WriteLine("- Você está bem?");

            Console.ReadLine();

            Console.WriteLine("Ela olha para você emocionada.");
            Console.WriteLine("- Estou, estou sim. Muitíssimo obrigada! Você salvou a minha vida... Mas como você conseguiu fazer isso?");

            Console.ReadLine();

            Console.WriteLine("Você olha para ela com uma expressão confusa.");
            Console.WriteLine("- Ué... Fazer o quê?");

            Console.ReadLine();

            Console.WriteLine("- Ser corajosa assim, sem medo, enfrentá-lo desse jeito.");

            Console.ReadLine();

            Console.WriteLine("Você pensa um pouco e logo responde.");
            Console.WriteLine("- Hmm... Mas é assim que deveria ser, não é? Nós devemos ter coragem para enfrentarmos os problemas apesar dos medos.");

            Console.ReadLine();

            Console.WriteLine("Ela esboça uma expressão triste.");
            Console.WriteLine("- Eu queria ser assim, você faz parecer que é tão simples...");

            Console.ReadLine();

            Console.WriteLine("Você sorri para ela e a conforta.");
            Console.WriteLine("- Você também tem essa força dentro de si, mas você precisa acreditar nisso. Você é tão capaz quanto eu ou qualquer outra pessoa, só precisa descobrir essa força dentro de si. Me prometa que vai tentar, ok?");

            Console.ReadLine();

            Console.WriteLine("Ela sorri e confirma com a cabeça, como agradecimento.");
            Console.WriteLine("- Tudo bem, então vou tentar! Obrigada por ter me ajudado, boa sorte em sua jornada.");

            Console.ReadLine();

            Console.WriteLine("Vocês se despedem com um abraço e você parte em direção à floresta.");

            Console.ReadLine();

            Console.WriteLine("\nPressione [ENTER] para trocar de fase...");
            Console.ReadLine();

            SecondPhase();
        }

        private void SecondPhase() // FLORESTA
        {
            stage = 2;
            Console.Clear();

            Console.WriteLine("Na floresta... \n");

            Console.WriteLine("Você anda pela floresta e se depara com uma trilha que nunca estivera ali antes.");

            Console.WriteLine("\nPressione [ENTER] para checar a trilha.");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Caminhando pela trilha as árvores se movem e abrem o caminho para você, se fechando no topo formando um arco, quase como se estivessem te convidando a entrar.");

            Console.ReadLine();

            Console.WriteLine("Você encontra um lindo bosque mágico.");

            Console.ReadLine();

            Console.WriteLine("Um bosque iluminado por vagalumes e suas luzes refletidas em um lago... \nPerfumado por inúmeras flores de diversas cores e tamanhos. ");

            Console.ReadLine();

            Console.WriteLine("Maravilhada com o que vê, você pergunta para si mesma:\n- Como um lugar desses passou despercebido por tantos anos? ");

            Console.ReadLine();

            Console.WriteLine("Você nota um pequeno pilar envolto em vinhas e caminha na direção dele.");

            Console.WriteLine("Uma presença chama a sua atenção. É uma mulher, mas não parece ter uma forma física... Quase como se fosse um espectro.");

            Console.ReadLine();

            Console.WriteLine("Você ouve uma voz suave.");
            Console.WriteLine("- Seja bem vinda Grande Guerreira, nós estávamos te aguardando...");

            Console.ReadLine();

            Console.WriteLine("Você aperta os olhos, tentando enxergar melhor a mulher espectral.");
            Console.WriteLine("- Quem está aí?!");

            Console.ReadLine();

            Console.WriteLine("A mulher se aproxima, diversas outras mulheres aparecem ao redor.");
            Console.WriteLine("- Não se assuste, estamos aqui para ajudar.");

            Console.ReadLine();

            Console.WriteLine("Você questiona sem entender o que é tudo aquilo.");
            Console.WriteLine("- Quem são vocês? O que está acontecendo?");

            Console.ReadLine();

            Console.WriteLine("- Alguns nos chamam de Guardiãs, Fadas, Amazonas, mas não nos prendemos à essas definições. Somos o que quisermos. A única certeza sobre nós é que estamos aqui para ajudar e proteger aquelas que precisam.");

            Console.ReadLine();

            Console.WriteLine("Ela estende a mão em direção ao pilar...");
            Console.WriteLine("E uma arma surge de repente!");

            Console.ReadLine();

            Console.WriteLine("- Uma Grande Guerreira merece batalhar com equipamento à altura, por isso, preparamos este presente para você...");

            Console.ReadLine();

            Console.WriteLine($"\nVocê recebeu {WeaponName()}.");

            Console.ReadLine();

            Console.WriteLine("- Enquanto você confiar em si mesma, agir sempre com coragem e bondade, essa arma lhe protegerá e nenhum mal poderá te impedir de alcançar seu objetivo.");

            Console.ReadLine();

            Console.WriteLine("Você questiona ainda um pouco confusa.");
            Console.WriteLine("- Mas... Por que vocês estão me ajudando?");

            Console.ReadLine();

            Console.WriteLine("Ela sorri pra você e lhe responde.");
            Console.WriteLine("- E por qual motivo não ajudaríamos? Vejo em seu coração que você também luta por todas nós.");

            Console.ReadLine();

            Console.WriteLine("Você observa o presente recebido ainda sem acreditar no que está acontecendo.");
            Console.WriteLine("- Que tal uma luta de aquecimento? Nós somos imortais mas podemos te ajudar a se acostumar com a sua arma nova.");

            Console.ReadLine();

            Console.WriteLine("Você se surpreende com a proposta.");
            Console.WriteLine("- O que?! Enfrentarei todas vocês?");

            Console.ReadLine();

            Console.WriteLine("- Hahaha! Quem sabe no futuro, mas apenas eu lutarei com você dessa vez.");
            Console.WriteLine("Você confirma com a cabeça.");

            Console.ReadLine();

            Console.WriteLine("\nINICIANDO DUELO...");
            Console.ReadLine();

            Console.Clear();

            inimigo.SpawnEnemy("Guardiã Mãe");
            Duel();

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("A Guardiã sorri para você.");
            Console.WriteLine("- Vejo que está pronta para o seu destino. ");

            Console.ReadLine();

            Console.WriteLine("A imagem das guardiãs começa a se dissipar.");

            Console.ReadLine();

            Console.WriteLine("- Esperem! Eu ainda tenho algumas perguntas!");

            Console.ReadLine();

            Console.WriteLine($"- Não se esqueça {this.nameHero}, siga sempre com sabedoria, coragem e bondade.");
            Console.WriteLine("\nElas somem.");

            Console.ReadLine();

            Console.WriteLine("...");

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Você se direciona para a saída do bosque e entra no arco formado pelas árvores anteriormente.");
            Console.WriteLine("\nConforme você caminha, o arco é fechado atrás de você.");

            Console.ReadLine();

            Console.WriteLine("Ao retornar para a trilha da floresta, o caminho para o bosque foi totalmente fechado, como se nunca tivesse existido.");

            Console.ReadLine();

            Console.WriteLine("Você segue em direção à cidade...");

            Console.WriteLine("\nPressione [ENTER] para trocar de fase...");

            Console.ReadLine();

            ThirdPhase();
        }

        private void ThirdPhase() // ENTRADA DA CIDADE
        {
            stage = 3;

            Console.Clear();

            Console.WriteLine("Na entrada da cidade...");

            Console.WriteLine("\nAo chegar, você percebe que há uma fila para entrar, feita de homens e alguns casais.");

            Console.ReadLine();
            Console.WriteLine("Você segue a fila, aguardando sua vez...");

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Sua vez chega, mas você é barrada pelo guarda.");
            Console.WriteLine("- Senhora, espere um momento. Você não pode entrar sozinha, onde está seu marido?");

            Console.ReadLine();

            Console.WriteLine("- Não sou casada, e como assim não posso entrar sozinha?");

            Console.ReadLine();

            Console.WriteLine("Ele se posiciona na sua frente, impedindo a passagem.");
            Console.WriteLine("- Não posso permitir a entrada da senhora nesse caso, apenas mulheres acompanhadas do chefe da família podem entrar na cidade.");

            Console.ReadLine();

            Console.WriteLine("Você não consegue acreditar no que acabou de ouvir.");
            Console.WriteLine("- O que?! Mas isso é um absurdo. E se eu for a chefe da minha família?");

            Console.ReadLine();

            Console.WriteLine("Ele e os demais guardas dão risada da situação.");
            Console.WriteLine("- Hahahaha! Como se isso fosse possível. Uma mulher não tem a mesma força e capacidade de um homem para ser chefe de família.");

            Console.ReadLine();

            Console.WriteLine("Você repete a pergunta.");
            Console.WriteLine("- E se eu for a chefe da minha família? Eu vou poder entrar?");

            Console.ReadLine();

            Console.WriteLine("Ele estranha sua reação e questiona.");
            Console.WriteLine("- E como é que você vai provar isso?");

            Console.ReadLine();

            Console.WriteLine("Você fica em posição de luta.");
            Console.WriteLine("- Te desafio a um duelo, se eu ganhar e mostrar que sou tão forte quanto você, você vai ter que me deixa entrar.");

            Console.ReadLine();

            Console.WriteLine("Ele da risada mais uma vez, e se posiciona para a luta.");
            Console.WriteLine("- Hahaha! Quero só ver então.");

            Console.WriteLine("\nPressione [ENTER] para lutar.");

            Console.ReadLine();

            Console.WriteLine("\nINICIANDO DUELO...");
            Console.ReadLine();

            Console.Clear();

            inimigo.SpawnEnemy("Guarda");
            Duel();

            Console.ReadLine();

            Console.Clear();


            Console.WriteLine("O guarda está ajoelhado, apoiado em sua espada.");
            Console.WriteLine("- Urgh! Está certo, você provou ser forte, deixem-na entrar.");

            Console.ReadLine();

            Console.WriteLine("Você atravessa os portões e entra na cidade.");

            Console.WriteLine("\nPressione [ENTER] para trocar de fase...");
            Console.ReadLine();

            FourthPhase();
        }

        private void FourthPhase() // INSCRIÇÃO DO TORNEIO
        {
            stage = 4;

            Console.Clear();

            Console.WriteLine("Dentro da cidade...");

            Console.WriteLine("\nVocê descobre que está acontecendo um torneio, onde o vencedor poderá visitar O Grande Castelo do Rei da Cocada Preta e desfrutar de um maravilhoso banquete feito por sua mãe.");

            Console.WriteLine("\nEssa é sua chance!");

            Console.WriteLine("\n\nPressione [ENTER] para ir ao torneio.");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Chegando na entrada do torneio você é barrada pelo organizador.");
            Console.WriteLine("- Ei, a entrada para assistir é do outro lado. Aqui é a entrada para os guerreiros, sabe? Os que vão para a luta.");

            Console.ReadLine();

            Console.WriteLine("Você o encara e responde sem hesitar.");
            Console.WriteLine("- Sim, eu sei. Sou uma guerreira, vou lutar.");

            Console.ReadLine();

            Console.WriteLine("- HAHAHAHA!! Você?! Uma mulher? Essa é boa.");
            Console.WriteLine("O homem percebe que você não está rindo.");
            Console.WriteLine("- Espera, é sério?");

            Console.ReadLine();

            Console.WriteLine("Você o encara nos olhos.");
            Console.WriteLine("- E por qual razão não seria?");

            Console.ReadLine();

            Console.WriteLine("Ele fica sem reação e começa a gaguejar.");
            Console.WriteLine("- Bom... É... N-não tem razão, quer dizer... É que... Bom... Eu não sei se eu posso... Deixar você participar...");

            Console.ReadLine();

            Console.WriteLine("Você tira um saco de moedas e coloca na frente dele.");
            Console.WriteLine("- Se o problema for taxa de inscrição, eu tenho o dinheiro.");

            Console.ReadLine();

            Console.WriteLine("Ele coça a testa e aparenta estar ainda mais sem saber o que fazer.");
            Console.WriteLine("- Bom, parece que você não vai desistir... Então está bem, façamos o seguinte, se você me vencer em um combate te deixo participar. Eu vou pegar leve então não se preocupe, é só para saber se você sabe lutar mesmo.");

            Console.ReadLine();

            Console.WriteLine("Você ri.");
            Console.WriteLine("- Ha! É melhor se preocupar consigo mesmo.");

            Console.ReadLine();

            Console.WriteLine("\nINICIANDO DUELO...");
            Console.ReadLine();

            Console.Clear();

            inimigo.SpawnEnemy("Organizador");
            Duel();

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("O organizador do torneio está suando e ofegante, caído no chão. Todos estão te aplaudindo.");
            Console.WriteLine("- Huff.. Huff... Não esperava uma mulher ser tão forte assim... Está bem, pode participar do torneio, mas não sei quanto tempo você vai durar lá.");

            Console.ReadLine();

            Console.WriteLine("Você guarda sua arma e sorri.");
            Console.WriteLine("- Muito obrigada, agora se me dá licença...");
            Console.WriteLine("\nVocê entra no torneio.");

            Console.ReadLine();

            Console.WriteLine("As pessoas dando risada, encaram o organizador sentado no chão.");
            Console.WriteLine("- E-eu peguei leve gente, foi só por isso...");

            Console.WriteLine("\nPressione [ENTER] para trocar de fase...");
            Console.ReadLine();

            FifthPhase();
        }

        private void FifthPhase() // TORNEIO
        {
            stage = 5;
            Console.Clear();

            Console.WriteLine("Dentro do torneio...");

            Console.WriteLine("\n- Senhoras e senhores, começa agora a comepetição mais esperada, o torneio 'Os Fortões'! E como todos sabem, o vencedor será premiado com um delicioso banquete no Grande Castelo do nosso Rei! Mas dessa vez temos uma ilustre presença... Acreditem se quiser, mas hoje temos uma competidora! Isso mesmo, temos uma mulher competindo!");

            Console.ReadLine();

            Console.WriteLine("Com o anúncio do locutor é possível ouvir muitos aplausos, mas também algumas risadas.");

            Console.WriteLine("- Eu espero que vocês estejam animados, porque eu certamente estou! E que começe a luta!!!");


            Console.WriteLine("\nPressione [ENTER] para lutar.");

            Console.ReadLine();
            Console.WriteLine("\nINICIANDO DUELO...");
            Console.ReadLine();

            Console.Clear();

            inimigo.SpawnEnemy("Competidor 1");
            Duel();

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"E a vencedora da primeira luta é {this.nameHero}!! E que comece a próxima luta!");

            Console.WriteLine("\nPressione [ENTER] para lutar.");

            Console.ReadLine();
            Console.WriteLine("\nINICIANDO DUELO...");
            Console.ReadLine();

            Console.Clear();

            inimigo.SpawnEnemy("Competidor 2");
            Duel();

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"- É incrível!! {this.nameHero} venceu mais uma vez! Vamos para a final!!");

            Console.WriteLine("\nPressione [ENTER] para lutar.");

            Console.ReadLine();
            Console.WriteLine("\nINICIANDO DUELO...");
            Console.ReadLine();

            Console.Clear();

            inimigo.SpawnEnemy("Competidor 3");
            Duel();

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"- Senhoras e senhores, pela primeira vez não temos um vencedor, mas sim uma VENCEDORA!! O prêmio vai para... {this.nameHero.ToUpper()}!!!!!!!!");

            Console.WriteLine("\nVocê recebe muitos aplausos, principalmente das mulheres na plateia, você se curva em forma de agradecimento e se retira do torneio...");

            Console.ReadLine();

            Console.WriteLine("No lado de fora há uma carruagem te aguardando, você entra na carruagem e ela sai em direção ao castelo.");

            Console.WriteLine("\nPressione [ENTER] para trocar de fase...");
            Console.ReadLine();

            SixthPhase();
        }

        private void SixthPhase() // CASTELO E DUELO FINAL
        {
            stage = 6;
            Console.Clear();

            Console.WriteLine("Chegando ao... Grande Castelo do Rei da Cocada Preta.");

            Console.WriteLine("\nVocê chega ao castelo e descobre que ele não tem tanta coisa assim de Castelo, é apenas uma casa comum.");

            Console.WriteLine("Mas bem... O que podia se esperar de alguém que se auto entitulou de 'Rei da Cocada Preta'...");

            Console.ReadLine();

            Console.WriteLine("A mãe do 'rei' já está te aguardando na porta, com um sorriso acolhedor em seu rosto.");
            Console.WriteLine("- Olá Grande Guerreira, seja muito bem vinda! Já está tudo preparado para você, entre por favor.");

            Console.WriteLine("\nPressione [ENTER] para entrar.");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("A mãe do rei te acompanha até a sala de jantar, onde a refeição está servida. Um aroma delicioso está preenchendo a sala.");
            Console.WriteLine("\n\nVocê se senta à mesa e pede para que ela sente-se também.");
            Console.WriteLine("- A senhora fez tudo isso sozinha?");

            Console.ReadLine();

            Console.WriteLine("Ela responde de uma forma como se estivesse dizendo o óbvio.");
            Console.WriteLine("- Ué minha querida, mas é claro que sim.");

            Console.ReadLine();

            Console.WriteLine("- Mas... Ele- O 'rei'... Não te ajuda em nada por aqui?");
            Console.WriteLine("\nEla se surpreende com a pergunta e até mesmo ri.");
            Console.WriteLine("- Ele me ajudar? Hahaha que bobagem... Ele é homem, não deveria fazer os deveres de uma dona de casa. Aliás, a senhorita é muito bonita, deveria também aprender a ser uma boa dona de casa e esposa, essas coisas de guerreiros não são para nós mulheres, sabe... ");

            Console.ReadLine();

            Console.WriteLine("Você tenta esconder seu espanto, afinal, ela também está sob efeito do feitiço...");
            Console.WriteLine("- Ah sim... Entendo...");

            Console.ReadLine();

            Console.WriteLine("Você termina sua refeição.");
            Console.WriteLine("- Muito obrigada pelo banquete, estava tudo delicioso.");

            Console.ReadLine();

            Console.WriteLine("Ela sorri para você.");
            Console.WriteLine("- Por nada minha querida, faça uma boa viagem de volta.");

            Console.WriteLine("\n- Eu... também gostaria de agradecer seu filho pelo banquete, onde posso encontrá-lo?");

            Console.ReadLine();

            Console.WriteLine("Ela aponta para a escada.");
            Console.WriteLine("- Ele fica sempre em seu quarto, é subindo as escadas, o quarto no final do corredor.");

            Console.WriteLine("\nVocê agradece mais uma vez e sobe as escadas...");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Você chega na porta do quarto e ouve uma voz vindo de dentro.");
            Console.WriteLine($"- Você deve ser {this.nameHero}, a Guerreira de que todos falam... Entre, eu estava lhe aguardando.");

            Console.ReadLine();

            Console.WriteLine("Você entra no quarto, ele está de costas, olhando para a janela.");
            Console.WriteLine("- E então... O que você veio fazer por aqui?");

            Console.ReadLine();
            Console.WriteLine("- Eu vim lhe pedir para que faça com que tudo volte ao normal.");

            Console.ReadLine();
            Console.WriteLine("Ele se vira para você.");
            Console.WriteLine("- HAHAHAHA!! Eu fiz um favor para todos vocês, agora o mundo está como ele deveria ser. ");

            Console.ReadLine();

            Console.WriteLine("Você se prepara para a luta.");
            Console.WriteLine("- Então eu mesma colocarei um fim nessa sua loucura.");

            Console.WriteLine("\nPressione [ENTER] para lutar.");

            Console.ReadLine();
            Console.WriteLine("\nINICIANDO DUELO...");
            Console.ReadLine();

            Console.Clear();

            inimigo.SpawnBoss();
            Duel();

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Você derrota o Rei da Cocada Preta e liberta todos de seu feitiço...");

            Console.WriteLine("A mãe dele se desculpa com você e todos da cidade, e o coloca de castigo.");

            Console.ReadLine();

            Console.WriteLine("Você recebe uma carona de carruagem até o seu vilarejo como agradecimento por ter salvo a todos...");

            Console.ReadLine();

            Console.WriteLine("Durante o caminho de volta os moradores da cidade aplaudem e agradecem pelos seus esforços...");

            Console.ReadLine();

            Console.WriteLine("Na floresta não há nada de diferente, você apenas sente uma brisa suave passando por você, trazendo uma energia acolhedora...");

            Console.ReadLine();

            Console.WriteLine("Ao chegar no seu vilarejo, todos te aguardam alegremente, além disso a placa de entrada foi consertada e agora é possivel ler o nome novamente...");

            Console.ReadLine();

            Console.WriteLine("All for All.");

            Console.ReadLine();

            Console.WriteLine("\n\nFIM.");

            FinalCredits();
        }

        private void FinalCredits()
        {
            Console.Clear();

            Console.WriteLine("Primeiramente gostaria de te agradecer por jogar Do It Ourselves, que apesar de ser um jogo de mecânica simples, \nfoi feito com o objetivo de passar uma mensagem muito séria...");

            Console.ReadLine();

            Console.WriteLine("Ao longo desse jogo aconteceram muitas coisas que podem parecer absurdas, talvez até mesmo exageradas... \nMas são situações parecidas com as quais já passamos um dia ou pelo menos conhecemos alguém que já passou...");

            Console.ReadLine();

            Console.WriteLine("Mas apesar de tudo o que passamos e ouvimos diariamente, nos mantemos firmes, fortes, de pé. \nAssim como em Do It Ourselves, somos todas Guerreiras fortes e capazes de tudo!");

            Console.ReadLine();

            Console.WriteLine("Que você nunca desista de si mesma e que se mantenha fiel à sua essência, não permita que alguém diga que você não é capaz, porque você é!");

            Console.ReadLine();

            Console.WriteLine("Se ame por quem você é, se valorize, e se você já faz isso, se ame e se valorize ainda mais, porque você merece! ");

            Console.ReadLine();

            Console.WriteLine("Enquanto você acreditar no seu potencial, ninguém será capaz de apagar o seu brilho...");

            Console.ReadLine();

            Console.WriteLine("E nunca se esqueça, siga sempre com sabedoria, coragem e bondade...");

            Console.ReadLine();

            Console.WriteLine("\nE mais uma vez... Obrigada por jogar! :)");

            Console.ReadLine();

            Console.Clear();
            GamePhase.Start();

        }

        private void Duel()
        {
            if (this.typeHero == "1") // CAVALEIRA
            {
                string escolha = "";

                while (cavaleira.GetHP() > 0 && inimigo.GetHP() > 0) // enquanto o jogador E o inimigo tiverem HP
                {
                    Console.WriteLine(cavaleira.ToString());
                    Console.WriteLine($"\n{inimigo.ToString()}");

                    while (escolha != "1" && escolha != "2")
                    {
                        Console.WriteLine($"\nESCOLHA: \n[1] - ATACAR \n[2] - BENÇÃO (+{cavaleira.GetHeal()} HP)");
                        escolha = Console.ReadLine();

                        if (escolha != "1" && escolha != "2")
                        {
                            Console.WriteLine("\nOpção inválida, tente novamente.\n");
                        }
                    }

                    if (escolha == "1")
                    {
                        inimigo.TakeDamage(cavaleira.Attack());
                        if (inimigo.GetAliveStatus() == false)
                        {
                            cavaleira.LevelUp();
                            return;
                        }
                    }

                    else if (escolha == "2")
                    {
                        cavaleira.Heal();
                        Console.WriteLine($"\nVocê curou {cavaleira.GetHeal()} de vida\n");
                        Console.WriteLine(cavaleira.ToString());
                    }

                    if (inimigo.GetHP() > 0)
                    {
                        cavaleira.TakeDamage(inimigo.Attack(cavaleira.GetHP()));
                    }

                    escolha = "";

                    Console.ReadLine();
                    Console.Clear();

                }

            }

            else if (this.typeHero == "2") // FEITICEIRA
            {
                string escolha = "";

                while (feiticeira.GetHP() > 0 && inimigo.GetHP() > 0)
                {
                    Console.WriteLine(feiticeira.ToString());
                    Console.WriteLine($"\n{inimigo.ToString()}");

                    while (escolha != "1" && escolha != "2")
                    {
                        Console.WriteLine($"\nESCOLHA: \n[1] - ATACAR \n[2] - BENÇÃO (+{feiticeira.GetHeal()} HP)");
                        escolha = Console.ReadLine();

                        if (escolha != "1" && escolha != "2")
                        {
                            Console.WriteLine("\nOpção inválida, tente novamente.\n");
                        }
                    }

                    if (escolha == "1")
                    {
                        inimigo.TakeDamage(feiticeira.Attack());
                        if (inimigo.GetAliveStatus() == false)
                        {
                            feiticeira.LevelUp();
                            return;
                        }
                    }

                    else if (escolha == "2")
                    {
                        feiticeira.Heal();
                        Console.WriteLine($"\nVocê curou {feiticeira.GetHeal()} de vida\n");
                        Console.WriteLine(feiticeira.ToString());
                    }

                    if (inimigo.GetHP() > 0)
                    {
                        feiticeira.TakeDamage(inimigo.Attack(feiticeira.GetHP()));
                    }

                    escolha = "";

                    Console.ReadLine();
                    Console.Clear();

                }

            }

            else if (this.typeHero == "3") // ARQUEIRA
            {

                string escolha = "";

                while (arqueira.GetHP() > 0 && inimigo.GetHP() > 0)
                {
                    Console.WriteLine(arqueira.ToString());
                    Console.WriteLine($"\n{inimigo.ToString()}");

                    while (escolha != "1" && escolha != "2")
                    {
                        Console.WriteLine($"\nESCOLHA: \n[1] - ATACAR \n[2] - BENÇÃO (+{arqueira.GetHeal()} HP)");
                        escolha = Console.ReadLine();

                        if (escolha != "1" && escolha != "2")
                        {
                            Console.WriteLine("\nOpção inválida, tente novamente.\n");
                        }
                    }

                    if (escolha == "1")
                    {
                        inimigo.TakeDamage(arqueira.Attack());
                        if (inimigo.GetAliveStatus() == false)
                        {
                            arqueira.LevelUp();
                            return;
                        }
                    }

                    else if (escolha == "2")
                    {
                        arqueira.Heal();
                        Console.WriteLine($"\nVocê curou {arqueira.GetHeal()} de vida\n");
                        Console.WriteLine(arqueira.ToString());
                    }

                    if (inimigo.GetHP() > 0)
                    {
                        arqueira.TakeDamage(inimigo.Attack(arqueira.GetHP()));
                    }

                    escolha = "";

                    Console.ReadLine();
                    Console.Clear();

                }

            }

            else if (this.typeHero == "4") // LUTADORA
            {
                string escolha = "";

                while (lutadora.GetHP() > 0 && inimigo.GetHP() > 0)
                {
                    Console.WriteLine(lutadora.ToString());
                    Console.WriteLine($"\n{inimigo.ToString()}");

                    while (escolha != "1" && escolha != "2")
                    {
                        Console.WriteLine($"\nESCOLHA: \n[1] - ATACAR \n[2] - BENÇÃO (+{lutadora.GetHeal()} HP)");
                        escolha = Console.ReadLine();

                        if (escolha != "1" && escolha != "2")
                        {
                            Console.WriteLine("\nOpção inválida, tente novamente.\n");
                        }
                    }

                    if (escolha == "1")
                    {
                        inimigo.TakeDamage(lutadora.Attack());
                        if (inimigo.GetAliveStatus() == false)
                        {
                            lutadora.LevelUp();
                            return;
                        }
                    }

                    else if (escolha == "2")
                    {
                        lutadora.Heal();
                        Console.WriteLine($"\nVocê curou {lutadora.GetHeal()} de vida\n");
                        Console.WriteLine(lutadora.ToString());
                    }

                    if (inimigo.GetHP() > 0)
                    {
                        lutadora.TakeDamage(inimigo.Attack(lutadora.GetHP()));
                    }

                    escolha = "";

                    Console.ReadLine();
                    Console.Clear();

                }

            }
        }

        private string WeaponName() 
        {
            if (this.typeHero == "1")
            {
                return "Espada da Sabedoria";
            }
            else if (this.typeHero == "2")
            {
                return "Cetro da Sabedoria";
            }
            else if (this.typeHero == "3")
            {
                return "Arco da Sabedoria";
            }
            else
                return "Luvas da Sabedoria";

        }
    }
}