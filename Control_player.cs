using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conf_game : MonoBehaviour
{
    // Ajuste de velocidade
    public float speed = 10;

    // Update is called once per frame
    void Update() // Aqui é a função resposavel para executar as ações enquanto o jogo estiver rodando
    {
        //transform.Translate(Vector3.forward); // Essa Linha de código faz com que o personagem ante infinitamente para prente
        // Isso é feito pois o comando transform faz com que o personagem se movimente
        // O comando .Translante faz com que ele ante ande em uma direção
        // O comando Vector3 faz que ele se diresone em umas das três direções sendo elas X;Y;Z
        // O comando forward E uma conficuração pré-estabelecida de (0,0,1) => Sendo assim uma configuração de um ponto para o eixo Z
        
        // Essas linhas de código foi uma sujestam do professor fazer analisar o comportamento do personame há ativala
        //transform.Translate(Vector3.right); // O personagem se movimentou pela lateral direita (0,1,0)
        //transform.Translate(Vector3.left); // O personagem se movimentou pela lateral esquerda (0,-1,0)
        //transform.Translate(Vector3.down); // O personagem se movimentou para baixo (-1,0,0)
        //transform.Translate(Vector3.up); // O personagem se movimentou para cima (1,0,0)
        //transform.Translate(Vector3.back); // O personagem se movimentou para trás (0,0,-1)

        // Colocar a movimentação do pesonagem segundo a diretrises da setas do teclado ou as teclas WASD
        
        // Pegando as informações mandadas para movimentação do personagem
        float axisX = Input.GetAxis("Horizontal"); // Horizontal é uma configuração pré-estabelecida que transforma as informação recebidas, pelas setas do teclado ou as teclas WASD, em valores númericos
        float axisZ = Input.GetAxis("Vertical"); // Vertical tambem é uma configuração pré-estabelecida e tem uase a mesma função do Horizontal
        //.GetAxis é uma sub-categoria de Input que entende as configurações mandadas esternamente e coverte em vetores

        // Criação de um vetor para direção do personagem
        Vector3 direction = new Vector3(axisX, 0, axisZ);
        
        // Colocando o vetor para movimentar o personagem
        //transform.Translate(direction);
        
        // LEMBRETE: Variável float serve para armazenar um valor númerico podedo ser valor frasonário cabendo um espaço de ate 32 bits
        // Input serve para receber uma informação externa do programa

        // Colocando velocidade para movimentação do personagem
        //transform.Translate(direction * Time.deltaTime); // Colocando a conf. Time.delaTime faz com que o personagem so ande 1 unidade por segundo. Anteriomente ele movia 1 unidade por FPS
        
        //transform.Translate(direction * 10 * Time.deltaTime); // Isso mutiplica a velocidade do personagem deixando sua momimentação programavel
        
        transform.Translate(direction * speed * Time.deltaTime); // Sendo assim, se for colocada uma variável no lugar do valor fixo, deixa o código com mais dinamismo
        // OBS: A Unity permite que você possa trocar esse vetor durante o testes do jogo, ajudando a ajustar o jogo

        // Colocando a logica para a movimentação do personagem 
        if(direction != Vector3.zero)
        {
            GetComponent<Animator>().SetBool("Moving", true); // GetComponent<> é o comando para acessar a abas dentro da Unity que não tem uma configuração especifica
        }
        else
        {
            GetComponent<Animator>().SetBool("Moving", false); // .SetBool permite trocar uma condição booleana de estado
        }

        // LEMBRETE: (Variável ou equação) != (Valor desejado) Serve para dizer para o computador avaliar se a variável ou a equação é diferente de do valor que você deseja
        // Vector3.zero é como definimos os trés vetores (X,Y,Z) como zero, pois caso fizecemos (0,0,0) pode ocorer erro de sintaxe no código mais para frente

    }
}
