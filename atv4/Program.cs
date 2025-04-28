#include <stdio.h>

int main()
{
    char conceito;

    printf("Digite o conceito do aluno (A, B, C, D, E): ");
    scanf(" %c", &conceito); 
    switch (conceito)
    {
        case 'A':
            printf("Conceito A: Excelente\n");
            break;
        case 'B':
            printf("Conceito B: Bom\n");
            break;
        case 'C':
            printf("Conceito C: Regular\n");
            break;
        case 'D':
            printf("Conceito D: Ruim\n");
            break;
        case 'E':
            printf("Conceito E: Péssimo\n");
            break;
        default:
            printf("Conceito inválido.\n");
            break;
    }

    return 0;
}
