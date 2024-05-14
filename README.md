# ProjetoA3_GQS
Projeto A3 - Gestão e Qualidade de Software - UnP 2024

O procedimento de alocar os arquivos por meio do git bash:

git init
git pull https://github.com/Coolffee/ProjetoA3_GQS.git
git commit -m "Sua descrição, pode ser data, horario"
git add .

Se mostrar o erro, exemplo:<div> error: open(".vs/AED/v16/Server/sqlite3/db.lock"): Permission denied error: unable to index file '.vs/AED/v16/Server/sqlite3/db.lock' fatal: adding files failed<\div>
<div>coloque touch .gitignore no git bash</div> 
<div>E coloque dentro do arquivo que .vs/ </div>
<div>E digite novamente git add .</div>
<div>git branch -M main</div> Ou pode ser uma outra banch para caso de querer testar outras versões e modificações utilizadas no código, mas main é a principal para colocar as coisas que estão funcionando 
<div>git remote add origin https://github.com/Coolffee/ProjetoA3_GQS.git
</div>
<div>git push origin main</div>
//se surgir algum erro no git fale no grupo do whats
