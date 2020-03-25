# Blazor-Server-Client

Changes:

Copied everything from master to SignalR_instance_Blazor branch:
git checkout -b "SignalR_instance_Blazor"
git checkout master .
git add --all
git commit -m "copying from master to branch"
git push --set-upstream origin SignalR_instance_Blazor


Made push force from completely different Project to Blazor-Server-Client repo master branch.
git init
git add -A
git commit -m 'Added my project'
git remote add origin git@github.com:scotch-io/my-new-project.git
git push -u -f origin master
