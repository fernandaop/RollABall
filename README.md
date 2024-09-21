# Roll-a-Ball  
**Fernanda de Oliveira Pereira**

## Objetivo
Roll-a-Ball é um projeto da disciplina **Jogos Digitais**, do 7º semestre de Engenharia da Computação no Insper. O projeto tem como objetivo o aprendizado da ferramenta **Unity**, a partir do tutorial ["Roll-a-Ball"](https://learn.unity.com/project/roll-a-ball). Com a base do jogo criada, foram implementadas melhorias e expansões de funcionalidades no jogo.

## Descrição do jogo - Versão **Dribble & Roll**
Em "Dribble & Roll", você controla uma bola de futebol em uma partida nada convencional. O objetivo é driblar os jogadores que tentam impedi-lo de coletar os **12 cubos** espalhados pelo campo, representando pontos de vitória. Você tem **3 vidas**, e a cada vez que um jogador adversário encosta em você, perde uma vida. 

Ao capturar todos os cubos, você avança para uma nova fase, onde o desafio aumenta com mais jogadores e velocidades maiores. Além disso, quanto mais rápido você capturar os cubos, mais pontos extras ganhará, incentivando uma jogabilidade estratégica que premia agilidade e precisão.

Durante o jogo, é possível monitorar a pontuação e o tempo em tempo real. Ao concluir cada fase, o tempo final e a pontuação total são exibidos.

## Funcionalidades Adicionadas

1. **Implementação Completa do Tutorial "Roll-a-Ball"**  
   - O tutorial oficial da Unity foi completamente concluído.

2. **Conquistando mais pontos**

   - **Mecânica de Tempo**  
     - **Adição de Cronômetro** (+0.5 pontos): O jogo exibe um cronômetro desde o início, nas duas fases, permitindo que o jogador acompanhe o tempo.  
     - **Exibição do Tempo Final** (+0.5 pontos): O tempo total de cada fase é mostrado ao final do jogo.  
     - **Bonificação por tempo** (+0.25 ~ 0.75 pontos): Na Fase 2, a pontuação extra é concedida dependendo da rapidez em capturar os cubos.  
     **Tabela de Bonificação:**  
     - Até 15 segundos: +15 pontos  
     - Até 25 segundos: +12 pontos  
     - Até 35 segundos: +10 pontos  
     - Até 45 segundos: +7 pontos  
     - Até 55 segundos: +5 pontos  
     - Até 60 segundos: +3 pontos  
     - Acima de 60 segundos: Nenhum ponto extra.

   - **Inimigos**  
     - **Movimento dos Inimigos** (+0.5 pontos): Na Fase 1, foram implementados 3 inimigos que se deslocam horizontalmente na velocidade 5. Na Fase 2, 2 inimigos extras foram adicionados, com movimento a velocidade 7.

   - **Visual**  
     - **Troca de cores dos Materiais** (+0.25 pontos): As cores foram ajustadas para o tema de futebol.  
     - **Uso de Texturas/Materiais** (+0.5 pontos): Materiais foram aplicados na bola e nos jogadores.

   - **Áudio**  
     - **Música no jogo** (+0.25 ~ 0.5 pontos): Uma música de aventura foi adicionada para aumentar a emoção da partida.

   - **UI**  
     - **Score e Tempo em tempo real** (+0.25 ~ 0.75 pontos): O score e o tempo são exibidos na interface durante toda a partida.  
     - **Exibição de Vidas** (+0.25 ~ 0.75 pontos): O jogador possui 3 vidas que são mostradas no topo da tela. Ao perder uma vida, a bola pisca em vermelho.

   - **Level Design**  
     - **Tema de Futebol** (+0.25 ~ 1.0 pontos): O tema de futebol foi aplicado ao jogo, com jogadores, bola, campo, além de título e imagem no menu inicial.  
     - **Modificação da Arena** (+0.25 ~ 1.0 pontos): A arena da Fase 2 foi modificada e expandida.  
     - **Desafios Adicionais** (+0.25 ~ 1.0 pontos): Na Fase 2, os inimigos são mais rápidos e o espaço de movimentação foi reduzido.

## Instruções de Jogo

**Controles:**  
- **Movimentação:** Use as teclas WASD ou as setas do teclado para controlar o movimento da bola.  
- **Estratégia:** Drible os jogadores e capture os cubos o mais rápido possível para ganhar pontos extras na Fase 2.  
- **Vida:** Você começa o jogo com 3 vidas. Cada vez que um jogador adversário tocar em você, você perderá uma vida.

**Fases:**  
- **Fase 1:** Colete os 12 cubos no campo enquanto evita os jogadores. Após pegar todos os cubos, você avança para a Fase 2.  
- **Fase 2:** Mais jogadores e velocidades mais altas aumentam o desafio. Existe uma segunda parte na fase, onde você deve subir uma rampa e enfrentar o desafio final. Quanto mais rápido completar essa fase, mais pontos bônus receberá.

**Acompanhamento em tempo real:**  
Durante a partida, você pode monitorar sua pontuação, o tempo decorrido e suas vidas restantes. Ao final de cada fase, o tempo total e a pontuação são exibidos.

## Referências

- [Tutorial Roll-a-Ball 1](https://youtu.be/zUUJZ8tH5_k?si=dKRJLePpw6x_w0RT)  
- [Tutorial Roll-a-Ball 2](https://youtu.be/syRVLH3PToA?si=Fgc9etA6zWLkRXkm)  
- [Tutorial Roll-a-Ball 3](https://youtu.be/K4uOjb5p3Io?si=h1gG10ataj6Gy44z)  
- [Tutorial Roll-a-Ball 4](https://youtu.be/ez9hYaGb7aI?si=r6AVQW0sCef3DhL1)  
- [Tutorial Roll-a-Ball 5](https://youtu.be/l7SwiFWOQqM?si=GEXmnzsbC1XbsbaH)

