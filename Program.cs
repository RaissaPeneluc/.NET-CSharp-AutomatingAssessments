        // Número de tarefas de exame
        int examAssignments = 5;

        // Nomes dos alunos
        string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

        // Notas dos alunos em arrays separados
        int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
        int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = { 90, 95, 87, 88, 96, 96 };

        // Array temporário para armazenar as notas do aluno atual
        int[] studentScores = new int[10];

        // Variável para armazenar a nota do aluno em formato de letra
        string currentStudentLetterGrade = "";

        // Mostra o cabeçalho do relatório de notas
        Console.Clear();
        Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

        // Loop externo para percorrer os nomes dos alunos
        foreach (string name in studentNames)
        {
            string currentStudent = name;

            // Atribui as notas do aluno atual ao array correspondente
            if (currentStudent == "Sophia")
                studentScores = sophiaScores;
            else if (currentStudent == "Andrew")
                studentScores = andrewScores;
            else if (currentStudent == "Emma")
                studentScores = emmaScores;
            else if (currentStudent == "Logan")
                studentScores = loganScores;

            // Variáveis para calcular as médias e notas do aluno
            int gradedAssignments = 0;
            int gradedExtraCreditAssignments = 0;
            int sumExamScores = 0;
            int sumExtraCreditScores = 0;
            decimal currentStudentGrade = 0;
            decimal currentStudentExamScore = 0;
            decimal currentStudentExtraCreditScore = 0;

            // Loop interno para percorrer as notas do aluno atual
            foreach (int score in studentScores)
            {
                gradedAssignments += 1;

                // Soma as notas dos exames
                if (gradedAssignments <= examAssignments)
                    sumExamScores += score;
                else
                {
                    // Conta as notas de pontos extras
                    gradedExtraCreditAssignments += 1;
                    sumExtraCreditScores += score;
                }
            }

            // Calcula as médias das notas dos exames e pontos extras
            currentStudentExamScore = (decimal)sumExamScores / examAssignments;
            currentStudentExtraCreditScore = (decimal)sumExtraCreditScores / gradedExtraCreditAssignments;

            // Calcula a nota final do aluno
            currentStudentGrade = (sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

            // Determina a nota em formato de letra com base na nota final
            if (currentStudentGrade >= 97)
                currentStudentLetterGrade = "A+";
            else if (currentStudentGrade >= 93)
                currentStudentLetterGrade = "A";
            else if (currentStudentGrade >= 90)
                currentStudentLetterGrade = "A-";
            else if (currentStudentGrade >= 87)
                currentStudentLetterGrade = "B+";
            else if (currentStudentGrade >= 83)
                currentStudentLetterGrade = "B";
            else if (currentStudentGrade >= 80)
                currentStudentLetterGrade = "B-";
            else if (currentStudentGrade >= 77)
                currentStudentLetterGrade = "C+";
            else if (currentStudentGrade >= 73)
                currentStudentLetterGrade = "C";
            else if (currentStudentGrade >= 70)
                currentStudentLetterGrade = "C-";
            else if (currentStudentGrade >= 67)
                currentStudentLetterGrade = "D+";
            else if (currentStudentGrade >= 63)
                currentStudentLetterGrade = "D";
            else if (currentStudentGrade >= 60)
                currentStudentLetterGrade = "D-";
            else
                currentStudentLetterGrade = "F";

            // Imprime os resultados do aluno atual
            Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore}({(decimal)sumExtraCreditScores / 10 / examAssignments} pts)");
        }

        // Aguarda a entrada do usuário para manter a janela do console aberta
        Console.WriteLine("\n\rPressione a tecla Enter para continuar");
        Console.ReadLine();
    

