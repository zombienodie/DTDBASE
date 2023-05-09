rd /s /q .git
git init
git config --global --add safe.directory E:/GITHUB
git add .
git config --global user.email "datdopentakill123@gmail.com"
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/zombienodie/DTDBASE.git
git push -f origin main
pause