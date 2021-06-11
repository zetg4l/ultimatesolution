pipeline {
    agent any
    environment 
    {
        dotnet = 'C:\\"Program Files"\\dotnet\\dotnet.exe'
    }
    stages {
        stage('Build') {
            steps {
                echo 'Building..'
                bat 'C:\\"Program Files"\\dotnet\\dotnet.exe build'
            }
        }
        stage('Run') {
            steps {
                echo 'Run..'
                bat 'C:\\"Program Files"\\dotnet\\dotnet.exe run'
            }
        }
        stage('Clean') {
            steps {
                echo 'Clean....'
                bat 'C:\\"Program Files"\\dotnet\\dotnet.exe clean'
            }
        }
    }
}