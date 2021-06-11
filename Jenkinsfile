pipeline {
    agent any
    enviroment 
    {
        dotnet = 'C:\\Program Files\\dotnet\\dotnet.exe'
    }
    stages {
        stage('Build') {
            steps {
                echo 'Building..'
                bat 'dotnet build'
            }
        }
        stage('Run') {
            steps {
                echo 'Run..'
                bat 'dotnet run'
            }
        }
        stage('Clean') {
            steps {
                echo 'Clean....'
                bat 'dotnet clean'
            }
        }
    }
}