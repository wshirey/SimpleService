node {
  stage 'Build application'
  docker('mono').inside {
    checkout scm
    sh 'nuget restore'
    sh 'xbuild SimpleService.sln'
  }
}
