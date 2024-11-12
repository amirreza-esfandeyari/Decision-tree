//  Add the following command to disable security warnings Visual Studio
 define _CRT_SECURE_NO_WARNINGS#

<include < stdio.h#
<include < string.h#

int main()
{
    char answer[4]; //  To save answers ("yes" or "no")

    printf("Q1:  are you tall (yes/no): ");
   scanf("%s", answer);

    switch (answer[0])
    { //  We only check the first letter (y  or  n)
        case 'y': // If the answer is "yes".
            printf("Q2:  Do you like walking? (yes/no): ");
            scanf("%s", answer);

            switch (answer[0])
            {
                case 'y':
                    printf("Q3: Do you like going to the cinema? (yes/no): ");
                    scanf("%s", answer);

                    switch (answer[0])
                    {
                        case 'y':
                            printf(" Suggestion: You may be a social and fun-loving person.\n");
                            break;
                        case 'n':
                            printf("Suggestion: You are interested in outdoor activities, but cinema is not very attractive.\n");
                            break;
                        default:
                            printf(" The answer is invalid.\n");
                            break;
                    }
                    break;

                case 'n':
                    printf("Q4:  Is studying good?  (yes/no): ");
                    scanf("%s", answer);

                    switch (answer[0])
                    {
                        case 'y':
                            printf(" Suggestion: You care about learning and are probably not into outdoor recreation.\n");
                            break;
                        case 'n':
                            printf(" Suggestion: You are not into fun or study and maybe you prefer other things.\n");
                            break;
                        default:
                            printf(" The answer is invalid.\n");
                            break;
                    }
                    break;

                default:
                    printf(" The answer is invalid.\n");
                    break;
            }
            break;

        case 'n': // If the answer is "no".
            printf("Q5:  Is autumn a good season? (yes/no): ");
            scanf("%s", answer);

            switch (answer[0])
            {
                case 'y':
                    printf(" Suggestion: You like autumn seasons and maybe you prefer cold seasons.\n");
                    break;
                case 'n':
                    printf("Suggestion: Maybe you are not interested in cold or autumn seasons.\n");
                    break;
                default:
                    printf(" The answer is invalid.\n");
                    break;
            }
            break;

        default:
            printf("  The answer is invalid. Please answer with 'yes' or 'no'.\n");
            break;
    }

    return 0;
}