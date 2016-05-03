node {
  stage 'Build application'
  docker.image('mono').inside {
    checkout scm
    sh 'nuget restore'
    sh 'xbuild SimpleService.sln'
  }
}
