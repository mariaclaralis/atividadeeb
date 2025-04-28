#include <stdio.h>

int main()
{
    int num1, num2;
    int operacao;

    
    printf("Digite o primeiro número: ");
    scanf("%d", &num1);

    printf("Digite o segundo número: ");
    scanf("%d", &num2);

    printf("Escolha a operação:\n");
    printf("1 - Soma\n");
    printf("2 - Subtração\n");
    printf("3 - Multiplicação\n");
    printf("4 - Divisão\n");
    printf("5 - Resto da divisão\n");
    printf("Digite a operação (1/2/3/4/5): ");
    scanf("%d", &operacao);

    
    switch (operacao)
    {
        case 1:
            printf("Resultado: %d\n", num1 + num2);
            break;
        case 2:
            printf("Resultado: %d\n", num1 - num2);
            break;
        case 3:
            printf("Resultado: %d\n", num1 * num2);
            break;
        case 4:
            if (num2 != 0)
            {
                printf("Resultado: %.2f\n", (float)num1 / num2);
            }
            else
            {
                printf("Erro: Divisão por zero!\n");
            }
            break;
        case 5:
            if (num2 != 0)
            {
                printf("Resultado: %d\n", num1 % num2);
            }
            else
            {
                printf("Erro: Não é possível calcular o resto da divisão por zero!\n");
            }
            break;
        default:
            printf("Operação inválida! Escolha entre 1, 2, 3, 4 ou 5.\n");
            break;
    }

    return 0;
}
