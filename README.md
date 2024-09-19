# Roll-a-Ball
Fernanda de Oliveira Pereira

Objetivo
Roll-a-Ball é um projeto da matéria Jogos Digitais do 7 semestre de Engenharia da Computação do Insper. O projeto tem como objetivo o aprendizado da ferramenta Unity, a partir do tutorial "Roll-a-Ball", disponibilizado em https://learn.unity.com/project/roll-a-ball. Com a base do jogo criada, foi implementado algumas melhorias e expansões de funcionalidades no jogo.

Descrição do jogo Roll-a-Ball - versão Dribble & Roll
Em "Dribble & Roll", você controla uma bola de futebol em uma partida nada convencional. Seu objetivo é driblar os jogadores de futebol que tentam impedi-lo de coletar os 12 cubos espalhados pelo campo, representando os pontos de vitória. Com apenas 3 vidas, você perde uma a cada vez que um jogador adversário encostar em você.
Ao capturar todos os cubos, você avança para uma nova fase, onde o desafio aumenta com mais jogadores e velocidades ainda maiores. Um dos diferenciais é que, quanto mais rápido você capturar os cubos, mais pontos extras você receberá, incentivando uma jogabilidade estratégica que premia a agilidade e precisão.
Durante o jogo, você pode monitorar sua pontuação e o tempo em tempo real. Ao concluir cada fase, seu tempo final e pontuação total serão exibidos, permitindo que você acompanhe seu desempenho.

Funcionalidades Adicionadas
1. Implementação Completa do Tutorial "Roll-a-Ball" (4 pontos): O tutorial oficial da Unity foi completamente concluído.

2.Conquistando mais pontos - 
  2.1. Mecânica de Tempo
    2.1.1. Adição de Cronômetro (+0.5 pontos): O jogo apresenta um cronômetro desde o início da partida, durante as 2 fases, permitindo que o jogador acompanhe o seu tempo durante todo o jogo.
    2.1.2. Exibição do Tempo Final (+0.5 pontos): O tempo total de cada fase é apresentado no final da partida.
    2.1.3. Utilizar o tempo como mecânica dentro do jogo (+0.25 ~ 0.75): Na Fase 2, o tempo foi utilizado como uma mecânica central, onde a pontuação do jogador aumenta dependendo da sua rapidez em completar a fase. Quanto mais ágil o jogador for ao coletar todos os cubos, mais pontos extras ele receberá. Abaixo está a tabela de bonificação com base no tempo:
Até 15 segundos: +15 pontos
Até 25 segundos: +12 pontos
Até 35 segundos: +10 pontos
Até 45 segundos: +7 pontos
Até 55 segundos: +5 pontos
Até 60 segundos: +3 pontos
Acima de 60 segundos: Nenhum ponto extra.
Essa mecânica incentiva os jogadores a serem mais rápidos e estratégicos para maximizar sua pontuação.

  2.2. Inimigos
    2.2.1. Implementar inimigos que se movam em direções pré-determinadas ou estejam parados, mas que causem algum impacto ao jogador (+0.5): Foi implementado, na fase 1, 3 inimigos (jogadores) que se deslocam horizontalmente na velocidade 5 durante toda a partida.  Na fase2 , além desses 3, foram acrescentados 2 inimigos com o mesmo movimento na velocidade 7.

  2.3. Visual
    2.3.1. Trocar a cor dos Materiais (+0.25 pontos): As cores dos materiais foram ajustadas para o tema de Futebol.
    2.3.2. Usar texturas/materiais de forma coerente (+0.5): Foi aplicado o material no jogadores e na bola.
  
  2.4. Áudio
    2.4.1. Adicionar música ao seu jogo (+ 0.25 ~ 0.5): Foi adicionado uma música de aventura, para dar mais agitação a partida.
  
  2.5. UI
    2.5.1. Exibir o score do jogador e o tempo atual na interface durante o jogo. (+0.25 ~ 0.75): O jogador acompanha seu score e tempo durante toda a fase 1 e 2.
    2.5.2. Mostrar outras informações importantes para o jogador (Vida, Stamina, etc) (+ 0.25 ~ 0.75): O jogador possui 3 vidas e pode acompanhar durante a partida na parte suerior central da tela. Além disso, se o jogadr perder uma vida, a sua coloração "pisca" na cor vermelha.

  2.6. Level Design
    2.7.1. Ajustar o jogo a algum tema ( +0.25 ~ 1.0): Foi aplicado um tema de Futebol, com jogadores, bola e campo simples, além de título e imagem no menu inicial.
    2.7.2. Criar uma nova arena ou modificar a arena básica (+ 0.25 ~ 1.0): Foi criado uma segunda fase com mais inimigos.
    2.7.3. Adicionar novos desafios para o jogador (+ 0.25 ~1.0): O desafio da segunda fase aumentou, fazendo com que ele tenha inimigos mais rápidos e diminuindo seu espaço de movimentação.

Instruções de Jogo

Controles:
- Movimentação: Use as teclas WASD ou as setas do teclado para controlar o movimento da bola.
- Estratégia: Drible os jogadores e capture todos os cubos o mais rápido possível para acumular pontos extras na Fase 2.
- Vida: Você começa o jogo com 3 vidas. Cada vez que um jogador adversário toca em você, você perde uma vida.
  
Fases:
- Fase 1: Colete os 12 cubos no campo enquanto evita os jogadores. Após pegar todos os cubos, você avança para a Fase 2.
- Fase 2: O número de jogadores aumenta, e suas velocidades ficam mais altas, tornando o desafio maior. Quanto mais rápido você completar essa fase, mais pontos bônus você receberá.
  
Acompanhamento em tempo real: Durante a partida, você pode monitorar sua pontuação atual, o tempo decorrido e quantas vidas restam. Ao final de cada fase, o tempo total e a pontuação são exibidos.

Referências:
https://youtu.be/zUUJZ8tH5_k?si=dKRJLePpw6x_w0RT
https://youtu.be/syRVLH3PToA?si=Fgc9etA6zWLkRXkm
https://youtu.be/K4uOjb5p3Io?si=h1gG10ataj6Gy44z
https://youtu.be/ez9hYaGb7aI?si=r6AVQW0sCef3DhL1
https://youtu.be/l7SwiFWOQqM?si=GEXmnzsbC1XbsbaH
