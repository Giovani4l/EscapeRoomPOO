namespace EscapeRoomPOO
{
    public static class IdiomaJuego
    {
        public enum Idioma
        {
            Español, English, Français, Deutsch, Italiano, Japanese, Korean, Chinese
        }

        public static Idioma IdiomaActual { get; private set; } = Idioma.Español;

        public static void CambiarIdioma(Idioma idioma) => IdiomaActual = idioma;

        // ── FormInicio ────────────────────────────────────────────────────────
        public static string SubtituloJuego => IdiomaActual switch
        {
            Idioma.English  => "Object Oriented Programming · C# Windows Forms",
            Idioma.Français => "Programmation Orientée Objet · C# Windows Forms",
            Idioma.Deutsch  => "Objektorientierte Programmierung · C# Windows Forms",
            Idioma.Italiano => "Programmazione Orientata agli Oggetti · C# Windows Forms",
            Idioma.Japanese => "オブジェクト指向プログラミング · C# Windows Forms",
            Idioma.Korean   => "객체 지향 프로그래밍 · C# Windows Forms",
            Idioma.Chinese  => "面向对象编程 · C# Windows Forms",
            _               => "Programación Orientada a Objetos · C# Windows Forms"
        };

        public static string MejorPuntaje(string puntaje) => IdiomaActual switch
        {
            Idioma.English  => $"Best score: {puntaje} pts",
            Idioma.Français => $"Meilleur score: {puntaje} pts",
            Idioma.Deutsch  => $"Bestes Ergebnis: {puntaje} Pkt.",
            Idioma.Italiano => $"Miglior punteggio: {puntaje} pt",
            Idioma.Japanese => $"ベストスコア: {puntaje} pt",
            Idioma.Korean   => $"최고 점수: {puntaje} pt",
            Idioma.Chinese  => $"最高分: {puntaje} 分",
            _               => $"Mejor puntaje: {puntaje} pts"
        };

        public static string BotonJugar => IdiomaActual switch
        {
            Idioma.English  => "PLAY",
            Idioma.Français => "JOUER",
            Idioma.Deutsch  => "SPIELEN",
            Idioma.Italiano => "GIOCA",
            Idioma.Japanese => "プレイ",
            Idioma.Korean   => "플레이",
            Idioma.Chinese  => "开始游戏",
            _               => "JUGAR"
        };

        public static string BotonHistorial => IdiomaActual switch
        {
            Idioma.English  => "HISTORY",
            Idioma.Français => "HISTORIQUE",
            Idioma.Deutsch  => "VERLAUF",
            Idioma.Italiano => "STORICO",
            Idioma.Japanese => "履歴",
            Idioma.Korean   => "기록",
            Idioma.Chinese  => "历史记录",
            _               => "HISTORIAL"
        };

        public static string BotonCargarPartida => IdiomaActual switch
        {
            Idioma.English  => "LOAD GAME",
            Idioma.Français => "CHARGER",
            Idioma.Deutsch  => "LADEN",
            Idioma.Italiano => "CARICA",
            Idioma.Japanese => "ロード",
            Idioma.Korean   => "불러오기",
            Idioma.Chinese  => "加载存档",
            _               => "CARGAR PARTIDA"
        };

        public static string InfoJuego => IdiomaActual switch
        {
            Idioma.English  => "3 puzzles per level  |  5 levels  |  60 seconds per level",
            Idioma.Français => "3 énigmes par niveau  |  5 niveaux  |  60 secondes par niveau",
            Idioma.Deutsch  => "3 Rätsel pro Stufe  |  5 Stufen  |  60 Sekunden pro Stufe",
            Idioma.Italiano => "3 enigmi per livello  |  5 livelli  |  60 secondi per livello",
            Idioma.Japanese => "レベルごとに3問  |  5レベル  |  1レベル60秒",
            Idioma.Korean   => "레벨당 3문제  |  5레벨  |  레벨당 60초",
            Idioma.Chinese  => "每关3题  |  5关  |  每关60秒",
            _               => "3 acertijos por nivel  |  5 niveles  |  60 segundos por nivel"
        };

        // ── FormJuego ─────────────────────────────────────────────────────────
        public static string EtiquetaNivel(int nivel, int total) => IdiomaActual switch
        {
            Idioma.English  => $"LEVEL {nivel} / {total}",
            Idioma.Français => $"NIVEAU {nivel} / {total}",
            Idioma.Deutsch  => $"STUFE {nivel} / {total}",
            Idioma.Italiano => $"LIVELLO {nivel} / {total}",
            Idioma.Japanese => $"レベル {nivel} / {total}",
            Idioma.Korean   => $"레벨 {nivel} / {total}",
            Idioma.Chinese  => $"关卡 {nivel} / {total}",
            _               => $"NIVEL {nivel} / {total}"
        };

        public static string EtiquetaPuntaje(int puntaje) => IdiomaActual switch
        {
            Idioma.English  => $"Score: {puntaje}",
            Idioma.Français => $"Score: {puntaje}",
            Idioma.Deutsch  => $"Punkte: {puntaje}",
            Idioma.Italiano => $"Punteggio: {puntaje}",
            Idioma.Japanese => $"スコア: {puntaje}",
            Idioma.Korean   => $"점수: {puntaje}",
            Idioma.Chinese  => $"分数: {puntaje}",
            _               => $"Puntaje: {puntaje}"
        };

        public static string EtiquetaMejorPuntaje(string puntaje) => IdiomaActual switch
        {
            Idioma.English  => $"Best: {puntaje} pts",
            Idioma.Français => $"Meilleur: {puntaje} pts",
            Idioma.Deutsch  => $"Bestes: {puntaje} Pkt.",
            Idioma.Italiano => $"Migliore: {puntaje} pt",
            Idioma.Japanese => $"最高: {puntaje} pt",
            Idioma.Korean   => $"최고: {puntaje} pt",
            Idioma.Chinese  => $"最高: {puntaje} 分",
            _               => $"Mejor: {puntaje} pts"
        };

        public static string EtiquetaIntentos(int intentos) => IdiomaActual switch
        {
            Idioma.English  => $"Attempts: {intentos}",
            Idioma.Français => $"Tentatives: {intentos}",
            Idioma.Deutsch  => $"Versuche: {intentos}",
            Idioma.Italiano => $"Tentativi: {intentos}",
            Idioma.Japanese => $"残り回数: {intentos}",
            Idioma.Korean   => $"시도: {intentos}",
            Idioma.Chinese  => $"剩余次数: {intentos}",
            _               => $"Intentos: {intentos}"
        };

        public static string EtiquetaProgreso(int actual, int total) => IdiomaActual switch
        {
            Idioma.English  => $"Puzzle {actual} of {total}",
            Idioma.Français => $"Énigme {actual} sur {total}",
            Idioma.Deutsch  => $"Rätsel {actual} von {total}",
            Idioma.Italiano => $"Enigma {actual} di {total}",
            Idioma.Japanese => $"問題 {actual} / {total}",
            Idioma.Korean   => $"문제 {actual} / {total}",
            Idioma.Chinese  => $"题目 {actual} / {total}",
            _               => $"Acertijo {actual} de {total}"
        };

        public static string MensajeCorrecto(int puntos) => IdiomaActual switch
        {
            Idioma.English  => $"Correct! +{puntos} points",
            Idioma.Français => $"Correct! +{puntos} points",
            Idioma.Deutsch  => $"Richtig! +{puntos} Punkte",
            Idioma.Italiano => $"Corretto! +{puntos} punti",
            Idioma.Japanese => $"正解！ +{puntos} pt",
            Idioma.Korean   => $"정답! +{puntos} 점",
            Idioma.Chinese  => $"正确！+{puntos} 分",
            _               => $"¡Correcto! +{puntos} puntos"
        };

        public static string MensajeIncorrecto(int intentosRestantes) => IdiomaActual switch
        {
            Idioma.English  => $"Wrong. {intentosRestantes} attempt(s) left.",
            Idioma.Français => $"Incorrect. {intentosRestantes} tentative(s) restante(s).",
            Idioma.Deutsch  => $"Falsch. Noch {intentosRestantes} Versuch(e).",
            Idioma.Italiano => $"Sbagliato. {intentosRestantes} tentativo(i) rimasto(i).",
            Idioma.Japanese => $"不正解。残り {intentosRestantes} 回。",
            Idioma.Korean   => $"틀렸습니다. {intentosRestantes}번 남았습니다.",
            Idioma.Chinese  => $"错误。还剩 {intentosRestantes} 次机会。",
            _               => $"Incorrecto. Te quedan {intentosRestantes} intento(s)."
        };

        public static string MensajeSinIntentos => IdiomaActual switch
        {
            Idioma.English  => "No attempts left. Game over!",
            Idioma.Français => "Plus de tentatives. Jeu terminé!",
            Idioma.Deutsch  => "Keine Versuche mehr. Spiel vorbei!",
            Idioma.Italiano => "Nessun tentativo rimasto. Fine del gioco!",
            Idioma.Japanese => "残り回数なし。ゲームオーバー！",
            Idioma.Korean   => "시도 횟수 소진. 게임 오버!",
            Idioma.Chinese  => "没有剩余次数。游戏结束！",
            _               => "Sin intentos. ¡Juego terminado!"
        };

        public static string MensajeRespuestaVacia => IdiomaActual switch
        {
            Idioma.English  => "Type an answer first.",
            Idioma.Français => "Écrivez une réponse d'abord.",
            Idioma.Deutsch  => "Geben Sie zuerst eine Antwort ein.",
            Idioma.Italiano => "Scrivi prima una risposta.",
            Idioma.Japanese => "最初に回答を入力してください。",
            Idioma.Korean   => "먼저 답을 입력하세요.",
            Idioma.Chinese  => "请先输入答案。",
            _               => "Escribe una respuesta primero."
        };

        public static string MensajePistaConfirmar => IdiomaActual switch
        {
            Idioma.English  => "Using a hint reduces your score. Continue?",
            Idioma.Français => "Utiliser un indice réduit votre score. Continuer?",
            Idioma.Deutsch  => "Ein Hinweis reduziert Ihre Punkte. Fortfahren?",
            Idioma.Italiano => "Usare un suggerimento riduce il punteggio. Continuare?",
            Idioma.Japanese => "ヒントを使うとスコアが減ります。続けますか？",
            Idioma.Korean   => "힌트를 사용하면 점수가 줄어듭니다. 계속하시겠습니까?",
            Idioma.Chinese  => "使用提示会减少分数。是否继续？",
            _               => "Pedir pista resta puntos. ¿Continuar?"
        };

        public static string TituloPista => IdiomaActual switch
        {
            Idioma.English  => "Hint",
            Idioma.Français => "Indice",
            Idioma.Deutsch  => "Hinweis",
            Idioma.Italiano => "Suggerimento",
            Idioma.Japanese => "ヒント",
            Idioma.Korean   => "힌트",
            Idioma.Chinese  => "提示",
            _               => "Pista"
        };

        public static string PrefijoPista => IdiomaActual switch
        {
            Idioma.English  => "Hint: ",
            Idioma.Français => "Indice: ",
            Idioma.Deutsch  => "Hinweis: ",
            Idioma.Italiano => "Suggerimento: ",
            Idioma.Japanese => "ヒント: ",
            Idioma.Korean   => "힌트: ",
            Idioma.Chinese  => "提示: ",
            _               => "Pista: "
        };

        public static string MensajeAbandonarConfirmar => IdiomaActual switch
        {
            Idioma.English  => "Are you sure you want to quit?",
            Idioma.Français => "Voulez-vous vraiment abandonner ?",
            Idioma.Deutsch  => "Möchten Sie wirklich aufgeben?",
            Idioma.Italiano => "Sei sicuro di voler abbandonare?",
            Idioma.Japanese => "本当に終了しますか？",
            Idioma.Korean   => "정말 포기하시겠습니까?",
            Idioma.Chinese  => "确定要放弃吗？",
            _               => "¿Seguro que quieres abandonar?"
        };

        public static string TituloAbandonar => IdiomaActual switch
        {
            Idioma.English  => "Quit",
            Idioma.Français => "Abandonner",
            Idioma.Deutsch  => "Aufgeben",
            Idioma.Italiano => "Abbandona",
            Idioma.Japanese => "終了",
            Idioma.Korean   => "포기",
            Idioma.Chinese  => "放弃",
            _               => "Abandonar"
        };

        public static string MensajeNivelSuperado(int nivel, int puntaje) => IdiomaActual switch
        {
            Idioma.English  => $"Level {nivel} cleared!\nScore: {puntaje}",
            Idioma.Français => $"Niveau {nivel} terminé!\nScore: {puntaje}",
            Idioma.Deutsch  => $"Stufe {nivel} geschafft!\nPunkte: {puntaje}",
            Idioma.Italiano => $"Livello {nivel} superato!\nPunteggio: {puntaje}",
            Idioma.Japanese => $"レベル {nivel} クリア！\nスコア: {puntaje}",
            Idioma.Korean   => $"레벨 {nivel} 완료!\n점수: {puntaje}",
            Idioma.Chinese  => $"第 {nivel} 关通过！\n分数: {puntaje}",
            _               => $"¡Nivel {nivel} superado!\nPuntaje: {puntaje}"
        };

        public static string TituloNivelCompletado => IdiomaActual switch
        {
            Idioma.English  => "Level complete!",
            Idioma.Français => "Niveau terminé!",
            Idioma.Deutsch  => "Stufe abgeschlossen!",
            Idioma.Italiano => "Livello completato!",
            Idioma.Japanese => "レベルクリア！",
            Idioma.Korean   => "레벨 완료!",
            Idioma.Chinese  => "关卡完成！",
            _               => "Nivel completado"
        };

        public static string BotonValidar => IdiomaActual switch
        {
            Idioma.English  => "Submit",
            Idioma.Français => "Valider",
            Idioma.Deutsch  => "Bestätigen",
            Idioma.Italiano => "Conferma",
            Idioma.Japanese => "回答する",
            Idioma.Korean   => "제출",
            Idioma.Chinese  => "提交",
            _               => "Validar"
        };

        public static string BotonPista => IdiomaActual switch
        {
            Idioma.English  => "Use hint",
            Idioma.Français => "Indice",
            Idioma.Deutsch  => "Hinweis",
            Idioma.Italiano => "Suggerimento",
            Idioma.Japanese => "ヒント",
            Idioma.Korean   => "힌트",
            Idioma.Chinese  => "提示",
            _               => "Pedir pista"
        };

        public static string BotonAbandonar => IdiomaActual switch
        {
            Idioma.English  => "Quit",
            Idioma.Français => "Abandonner",
            Idioma.Deutsch  => "Aufgeben",
            Idioma.Italiano => "Abbandona",
            Idioma.Japanese => "終了",
            Idioma.Korean   => "포기",
            Idioma.Chinese  => "放弃",
            _               => "Abandonar"
        };

        public static string BotonGuardarPartida => IdiomaActual switch
        {
            Idioma.English  => "Save game",
            Idioma.Français => "Sauvegarder",
            Idioma.Deutsch  => "Speichern",
            Idioma.Italiano => "Salva partita",
            Idioma.Japanese => "セーブ",
            Idioma.Korean   => "저장",
            Idioma.Chinese  => "保存游戏",
            _               => "Guardar partida"
        };

        // ── FormFinal ─────────────────────────────────────────────────────────
        public static string MensajeResultado(bool gano) => IdiomaActual switch
        {
            Idioma.English  => gano ? "You escaped!"         : "You didn't escape...",
            Idioma.Français => gano ? "Vous avez réussi!"    : "Vous n'avez pas réussi...",
            Idioma.Deutsch  => gano ? "Sie haben entkommen!" : "Sie sind nicht entkommen...",
            Idioma.Italiano => gano ? "Ce l'hai fatta!"      : "Non sei riuscito a scappare...",
            Idioma.Japanese => gano ? "脱出成功！"            : "脱出できませんでした...",
            Idioma.Korean   => gano ? "탈출 성공!"            : "탈출하지 못했습니다...",
            Idioma.Chinese  => gano ? "成功逃脱！"            : "未能逃脱...",
            _               => gano ? "¡Lo lograste!"        : "No lograste escapar..."
        };

        public static string EtiquetaPuntajeFinal(int puntaje) => IdiomaActual switch
        {
            Idioma.English  => $"Score: {puntaje} pts",
            Idioma.Français => $"Score: {puntaje} pts",
            Idioma.Deutsch  => $"Punkte: {puntaje}",
            Idioma.Italiano => $"Punteggio: {puntaje} pt",
            Idioma.Japanese => $"スコア: {puntaje} pt",
            Idioma.Korean   => $"점수: {puntaje} pt",
            Idioma.Chinese  => $"分数: {puntaje} 分",
            _               => $"Puntaje: {puntaje} pts"
        };

        public static string EtiquetaNivelAlcanzado(int nivel, int total) => IdiomaActual switch
        {
            Idioma.English  => $"Level reached: {nivel} / {total}",
            Idioma.Français => $"Niveau atteint: {nivel} / {total}",
            Idioma.Deutsch  => $"Erreichte Stufe: {nivel} / {total}",
            Idioma.Italiano => $"Livello raggiunto: {nivel} / {total}",
            Idioma.Japanese => $"到達レベル: {nivel} / {total}",
            Idioma.Korean   => $"도달 레벨: {nivel} / {total}",
            Idioma.Chinese  => $"到达关卡: {nivel} / {total}",
            _               => $"Nivel alcanzado: {nivel} / {total}"
        };

        public static string MensajeNuevoRecord => IdiomaActual switch
        {
            Idioma.English  => "New record!",
            Idioma.Français => "Nouveau record!",
            Idioma.Deutsch  => "Neuer Rekord!",
            Idioma.Italiano => "Nuovo record!",
            Idioma.Japanese => "新記録！",
            Idioma.Korean   => "새 기록!",
            Idioma.Chinese  => "新纪录！",
            _               => "¡Nuevo record!"
        };

        public static string MensajeMejorPuntaje(string puntaje) => IdiomaActual switch
        {
            Idioma.English  => $"Best score: {puntaje} pts",
            Idioma.Français => $"Meilleur score: {puntaje} pts",
            Idioma.Deutsch  => $"Bestes Ergebnis: {puntaje} Pkt.",
            Idioma.Italiano => $"Miglior punteggio: {puntaje} pt",
            Idioma.Japanese => $"ベストスコア: {puntaje} pt",
            Idioma.Korean   => $"최고 점수: {puntaje} pt",
            Idioma.Chinese  => $"最高分: {puntaje} 分",
            _               => $"Mejor puntaje: {puntaje} pts"
        };

        public static string BotonReiniciar => IdiomaActual switch
        {
            Idioma.English  => "Play again",
            Idioma.Français => "Rejouer",
            Idioma.Deutsch  => "Nochmal spielen",
            Idioma.Italiano => "Gioca ancora",
            Idioma.Japanese => "もう一度プレイ",
            Idioma.Korean   => "다시 플레이",
            Idioma.Chinese  => "再玩一次",
            _               => "Jugar de nuevo"
        };

        public static string BotonSalir => IdiomaActual switch
        {
            Idioma.English  => "Exit",
            Idioma.Français => "Quitter",
            Idioma.Deutsch  => "Beenden",
            Idioma.Italiano => "Esci",
            Idioma.Japanese => "終了",
            Idioma.Korean   => "종료",
            Idioma.Chinese  => "退出",
            _               => "Salir"
        };

        // ── Historial / Partidas ──────────────────────────────────────────────
        public static string TituloHistorial => IdiomaActual switch
        {
            Idioma.English  => "History",
            Idioma.Français => "Historique",
            Idioma.Deutsch  => "Verlauf",
            Idioma.Italiano => "Storico",
            Idioma.Japanese => "履歴",
            Idioma.Korean   => "기록",
            Idioma.Chinese  => "历史记录",
            _               => "Historial"
        };

        public static string MensajeGuardarNombre => IdiomaActual switch
        {
            Idioma.English  => "Enter a name for this save:",
            Idioma.Français => "Entrez un nom pour cette sauvegarde:",
            Idioma.Deutsch  => "Geben Sie einen Namen für diesen Speicherstand ein:",
            Idioma.Italiano => "Inserisci un nome per questo salvataggio:",
            Idioma.Japanese => "このセーブデータの名前を入力してください:",
            Idioma.Korean   => "이 저장 데이터의 이름을 입력하세요:",
            Idioma.Chinese  => "请输入此存档的名称:",
            _               => "Ingresa un nombre para esta partida:"
        };

        public static string MensajeRanuraLlena => IdiomaActual switch
        {
            Idioma.English  => "All 5 slots are full. Delete a save to continue.",
            Idioma.Français => "Les 5 emplacements sont pleins. Supprimez une sauvegarde.",
            Idioma.Deutsch  => "Alle 5 Slots sind voll. Löschen Sie einen Speicherstand.",
            Idioma.Italiano => "Tutti e 5 gli slot sono pieni. Elimina un salvataggio.",
            Idioma.Japanese => "5つのスロットがすべて埋まっています。削除してください。",
            Idioma.Korean   => "5개의 슬롯이 모두 가득 찼습니다. 저장 데이터를 삭제하세요.",
            Idioma.Chinese  => "5个存档槽已满。请删除一个存档。",
            _               => "Las 5 ranuras están llenas. Elimina una partida para continuar."
        };

        public static string MensajePartidaGuardada => IdiomaActual switch
        {
            Idioma.English  => "Game saved successfully.",
            Idioma.Français => "Partie sauvegardée avec succès.",
            Idioma.Deutsch  => "Spiel erfolgreich gespeichert.",
            Idioma.Italiano => "Partita salvata con successo.",
            Idioma.Japanese => "ゲームを保存しました。",
            Idioma.Korean   => "게임이 저장되었습니다.",
            Idioma.Chinese  => "游戏已成功保存。",
            _               => "Partida guardada correctamente."
        };

        public static string NombrePartidaGanada(int puntaje) => IdiomaActual switch
        {
            Idioma.English  => $"Victory — {puntaje} pts",
            Idioma.Français => $"Victoire — {puntaje} pts",
            Idioma.Deutsch  => $"Sieg — {puntaje} Pkt.",
            Idioma.Italiano => $"Vittoria — {puntaje} pt",
            Idioma.Japanese => $"クリア — {puntaje} pt",
            Idioma.Korean   => $"승리 — {puntaje} pt",
            Idioma.Chinese  => $"胜利 — {puntaje} 分",
            _               => $"Victoria — {puntaje} pts"
        };

        // ── Tipo de acertijo (mostrado en pantalla) ───────────────────────────
        public static string TipoMatematicas => IdiomaActual switch
        {
            Idioma.English  => "Mathematics",
            Idioma.Français => "Mathématiques",
            Idioma.Deutsch  => "Mathematik",
            Idioma.Italiano => "Matematica",
            Idioma.Japanese => "数学",
            Idioma.Korean   => "수학",
            Idioma.Chinese  => "数学",
            _               => "Matemáticas"
        };

        public static string TipoCompletarPalabra => IdiomaActual switch
        {
            Idioma.English  => "Complete the sentence",
            Idioma.Français => "Compléter la phrase",
            Idioma.Deutsch  => "Satz vervollständigen",
            Idioma.Italiano => "Completa la frase",
            Idioma.Japanese => "文章を完成させる",
            Idioma.Korean   => "문장 완성",
            Idioma.Chinese  => "完成句子",
            _               => "Completar palabra"
        };

        public static string TipoLogica => IdiomaActual switch
        {
            Idioma.English  => "Logic",
            Idioma.Français => "Logique",
            Idioma.Deutsch  => "Logik",
            Idioma.Italiano => "Logica",
            Idioma.Japanese => "論理",
            Idioma.Korean   => "논리",
            Idioma.Chinese  => "逻辑",
            _               => "Lógica"
        };

        // ── Pregunta y pista de AcertijoMatematico ────────────────────────────
        public static string PreguntaMatematica(int a, string op, int b) => IdiomaActual switch
        {
            Idioma.English  => $"What is {a} {op} {b}?",
            Idioma.Français => $"Combien fait {a} {op} {b} ?",
            Idioma.Deutsch  => $"Wie viel ist {a} {op} {b}?",
            Idioma.Italiano => $"Quanto fa {a} {op} {b}?",
            Idioma.Japanese => $"{a} {op} {b} はいくつですか？",
            Idioma.Korean   => $"{a} {op} {b} 은 얼마입니까?",
            Idioma.Chinese  => $"{a} {op} {b} 等于几？",
            _               => $"¿Cuánto es {a} {op} {b}?"
        };

        public static string PistaMatematica(int min, int max) => IdiomaActual switch
        {
            Idioma.English  => $"The result is between {min} and {max}",
            Idioma.Français => $"Le résultat est entre {min} et {max}",
            Idioma.Deutsch  => $"Das Ergebnis liegt zwischen {min} und {max}",
            Idioma.Italiano => $"Il risultato è tra {min} e {max}",
            Idioma.Japanese => $"答えは {min} から {max} の間です",
            Idioma.Korean   => $"결과는 {min}에서 {max} 사이입니다",
            Idioma.Chinese  => $"结果在 {min} 到 {max} 之间",
            _               => $"El resultado está entre {min} y {max}"
        };

        public static string IntroCompletarPalabra => IdiomaActual switch
        {
            Idioma.English  => "Complete the sentence:",
            Idioma.Français => "Complétez la phrase :",
            Idioma.Deutsch  => "Vervollständigen Sie den Satz:",
            Idioma.Italiano => "Completa la frase:",
            Idioma.Japanese => "文章を完成させてください：",
            Idioma.Korean   => "문장을 완성하세요:",
            Idioma.Chinese  => "完成这个句子：",
            _               => "Completa la oración:"
        };

        public static string PistaCompletarPalabra(int longitud, char inicial) => IdiomaActual switch
        {
            Idioma.English  => $"The word has {longitud} letters and starts with '{inicial}'",
            Idioma.Français => $"Le mot a {longitud} lettres et commence par '{inicial}'",
            Idioma.Deutsch  => $"Das Wort hat {longitud} Buchstaben und beginnt mit '{inicial}'",
            Idioma.Italiano => $"La parola ha {longitud} lettere e inizia con '{inicial}'",
            Idioma.Japanese => $"単語は {longitud} 文字で '{inicial}' で始まります",
            Idioma.Korean   => $"단어는 {longitud}글자이며 '{inicial}'로 시작합니다",
            Idioma.Chinese  => $"这个词有 {longitud} 个字母，以 '{inicial}' 开头",
            _               => $"La palabra tiene {longitud} letras y empieza con '{inicial}'"
        };

        // ── Banco de AcertijoCompletarPalabra por idioma ──────────────────────
        // Formato: { oracion_con___, respuesta }
        public static string[,] BancoCompletarPalabra => IdiomaActual switch
        {
            Idioma.English => new string[,]
            {
                { "The sky is ___ in color.",             "blue"      },
                { "The dog wags its ___.",                "tail"      },
                { "The Earth revolves around the ___.",   "sun"       },
                { "Water gets you wet, fire ___.",        "burns"     },
                { "In code, a ___ is an error.",          "bug"       },
                { "The opposite of true is ___.",         "false"     },
                { "An ___ defines a contract in OOP.",   "interface" },
                { "A class with no body is ___.",         "abstract"  },
                { "Redefining a method is called ___.",   "override"  },
                { "SOLID are ___ of design.",             "principles"},
            },
            Idioma.Français => new string[,]
            {
                { "Le ciel est de couleur ___.",          "bleu"      },
                { "Le chien remue la ___.",               "queue"     },
                { "La Terre tourne autour du ___.",       "soleil"    },
                { "L'eau mouille, le feu ___.",           "brûle"     },
                { "En code, un ___ est une erreur.",      "bug"       },
                { "Le contraire de vrai est ___.",        "faux"      },
                { "Une ___ définit un contrat en POO.",  "interface" },
                { "Une classe sans corps est ___.",       "abstraite" },
                { "Redéfinir une méthode c'est ___.",     "override"  },
                { "SOLID sont des ___ de conception.",    "principes" },
            },
            Idioma.Deutsch => new string[,]
            {
                { "Der Himmel ist ___ gefärbt.",                "blau"       },
                { "Der Hund wedelt mit dem ___.",               "schwanz"    },
                { "Die Erde dreht sich um die ___.",            "sonne"      },
                { "Wasser macht nass, Feuer ___.",              "brennt"     },
                { "Im Code ist ein ___ ein Fehler.",            "bug"        },
                { "Das Gegenteil von wahr ist ___.",            "falsch"     },
                { "Ein ___ definiert einen Vertrag in OOP.",   "interface"  },
                { "Eine Klasse ohne Körper ist ___.",           "abstrakt"   },
                { "Eine Methode neu definieren nennt man ___.", "überschreiben"},
                { "SOLID sind ___ des Entwurfs.",               "prinzipien" },
            },
            Idioma.Italiano => new string[,]
            {
                { "Il cielo è di colore ___.",             "blu"        },
                { "Il cane agita la ___.",                 "coda"       },
                { "La Terra ruota attorno al ___.",        "sole"       },
                { "L'acqua bagna, il fuoco ___.",          "brucia"     },
                { "Nel codice, un ___ è un errore.",       "bug"        },
                { "Il contrario di vero è ___.",           "falso"      },
                { "Un ___ definisce un contratto in OOP.","interfaccia"},
                { "Una classe senza corpo è ___.",         "astratta"   },
                { "Ridefinire un metodo si chiama ___.",   "override"   },
                { "SOLID sono ___ di progettazione.",      "principi"   },
            },
            Idioma.Japanese => new string[,]
            {
                { "空は___色です。",                    "青"         },
                { "犬は___を振ります。",               "しっぽ"     },
                { "地球は___の周りを回ります。",       "太陽"       },
                { "水は濡らし、火は___。",             "燃やす"     },
                { "コードでは___はエラーのことです。", "バグ"       },
                { "真の反対は___です。",               "偽"         },
                { "___はOOPの契約を定義します。",     "インターフェース"},
                { "本体のないクラスは___です。",       "抽象"       },
                { "メソッドを再定義することを___といいます。", "オーバーライド"},
                { "SOLIDは設計の___です。",            "原則"       },
            },
            Idioma.Korean => new string[,]
            {
                { "하늘은 ___ 색입니다.",               "파란"       },
                { "개는 ___를 흔듭니다.",               "꼬리"       },
                { "지구는 ___ 주위를 돕니다.",          "태양"       },
                { "물은 적시고, 불은 ___.",             "태운다"     },
                { "코드에서 ___는 오류입니다.",         "버그"       },
                { "참의 반대는 ___입니다.",             "거짓"       },
                { "___는 OOP에서 계약을 정의합니다.",  "인터페이스" },
                { "본문이 없는 클래스는 ___입니다.",    "추상"       },
                { "메서드를 재정의하는 것을 ___라고 합니다.", "오버라이드"},
                { "SOLID는 설계의 ___입니다.",          "원칙"       },
            },
            Idioma.Chinese => new string[,]
            {
                { "天空是___色的。",              "蓝"    },
                { "狗摇动它的___。",              "尾巴"  },
                { "地球围绕___旋转。",            "太阳"  },
                { "水使人湿，火___。",            "燃烧"  },
                { "在代码中，___是一个错误。",    "bug"   },
                { "真的反义词是___。",            "假"    },
                { "___在OOP中定义了一个契约。",  "接口"  },
                { "没有主体的类是___。",          "抽象"  },
                { "重新定义方法叫做___。",        "重写"  },
                { "SOLID是设计___。",             "原则"  },
            },
            _ => new string[,]
            {
                { "El cielo es de color ___.",           "azul"         },
                { "El perro mueve la ___.",               "cola"         },
                { "La Tierra gira alrededor del ___.",    "sol"          },
                { "El agua moja, el fuego ___.",          "quema"        },
                { "En código, un ___ es un error.",       "bug"          },
                { "El opuesto de verdadero es ___.",      "falso"        },
                { "Una ___ define un contrato en POO.",   "interfaz"     },
                { "Una clase sin cuerpo es ___.",         "abstracta"    },
                { "Redefinir un método es ___.",          "sobreescribir"},
                { "SOLID son ___ de diseño.",             "principios"   },
            }
        };

        // ── Banco de AcertijoLogica por idioma ────────────────────────────────
        // Formato: { pregunta, respuesta, pista }
        public static string[,] BancoLogica => IdiomaActual switch
        {
            Idioma.English => new string[,]
            {
                { "What has hands but cannot clap?",              "clock",    "It tells you the time"        },
                { "The more you dry, the more it soaks. What is it?", "towel","You use it after a shower"    },
                { "What breaks when you say its name?",           "silence",  "It's in a library"            },
                { "What moves forward but never backward?",       "time",     "You can't get it back"        },
                { "The more you take, the bigger it gets. What?", "hole",     "Dig it in the ground"         },
                { "You take 2 apples from 3. How many do you have?", "2",     "You took them..."             },
                { "What belongs to you but others use it more?",  "name",     "Given to you at birth"        },
                { "In C#, what keyword redefines a parent method?","override", "Goes before the return type"  },
                { "What OOP class cannot be instantiated directly?","abstract","Declared with 'abstract'"     },
                { "How many sides do a triangle and square have combined?","7","3 + 4"                        },
            },
            Idioma.Français => new string[,]
            {
                { "Qu'est-ce qui a des mains mais ne peut pas applaudir ?",    "horloge",  "Elle vous dit l'heure"       },
                { "Plus on l'essuie, plus ça mouille. Qu'est-ce que c'est ?",  "serviette","On l'utilise après la douche"},
                { "Qu'est-ce qui se brise quand on le nomme ?",                "silence",  "C'est dans une bibliothèque" },
                { "Qu'est-ce qui avance mais ne recule jamais ?",              "temps",    "On ne peut pas le récupérer" },
                { "Plus on en enlève, plus il grandit. Qu'est-ce que c'est ?", "trou",     "Creusez-le dans la terre"    },
                { "Vous prenez 2 pommes sur 3. Combien en avez-vous ?",        "2",        "Vous les avez prises..."     },
                { "Ce qui vous appartient mais que les autres utilisent plus ?","prénom",   "Donné à la naissance"        },
                { "En C#, quel mot-clé redéfinit une méthode parente ?",       "override", "Avant le type de retour"     },
                { "Quelle classe POO ne peut pas être instanciée directement ?","abstraite","Déclarée avec 'abstract'"    },
                { "Combien de côtés ont un triangle et un carré ensemble ?",    "7",        "3 + 4"                       },
            },
            Idioma.Deutsch => new string[,]
            {
                { "Was hat Hände, kann aber nicht klatschen?",              "uhr",       "Sie zeigt die Zeit an"       },
                { "Je mehr man trocknet, desto nasser wird es. Was ist es?","handtuch",  "Man benutzt es nach dem Duschen"},
                { "Was zerbricht, wenn man es ausspricht?",                 "stille",    "Es herrscht in der Bibliothek"},
                { "Was bewegt sich vorwärts, aber nie rückwärts?",         "zeit",      "Man kann sie nicht zurückbekommen"},
                { "Je mehr man wegnimmt, desto größer wird es. Was?",      "loch",      "In die Erde graben"          },
                { "Du nimmst 2 Äpfel von 3. Wie viele hast du?",           "2",         "Du hast sie genommen..."     },
                { "Was gehört dir, aber andere nutzen es mehr?",           "name",      "Bei der Geburt gegeben"      },
                { "Welches Schlüsselwort definiert eine Methode neu in C#?","override",  "Vor dem Rückgabetyp"         },
                { "Welche OOP-Klasse kann nicht instanziiert werden?",      "abstrakt",  "Mit 'abstract' deklariert"   },
                { "Wie viele Seiten haben ein Dreieck und ein Viereck zusammen?","7",   "3 + 4"                       },
            },
            Idioma.Italiano => new string[,]
            {
                { "Cosa ha le mani ma non può applaudire?",                 "orologio",  "Ti dice l'ora"               },
                { "Più lo asciughi, più bagna. Cos'è?",                    "asciugamano","Lo usi dopo la doccia"       },
                { "Cosa si rompe quando lo nomini?",                       "silenzio",  "È in una biblioteca"         },
                { "Cosa avanza ma non torna mai indietro?",                "tempo",     "Non puoi recuperarlo"        },
                { "Più togli, più diventa grande. Cos'è?",                 "buco",      "Scavalo nella terra"         },
                { "Prendi 2 mele da 3. Quante ne hai?",                    "2",         "Le hai prese tu..."          },
                { "Cosa ti appartiene ma gli altri lo usano di più?",      "nome",      "Dato alla nascita"           },
                { "In C#, quale parola ridefinisce un metodo del padre?",  "override",  "Prima del tipo di ritorno"   },
                { "Quale classe OOP non può essere istanziata direttamente?","astratta","Dichiarata con 'abstract'"   },
                { "Quanti lati hanno insieme un triangolo e un quadrato?", "7",         "3 + 4"                       },
            },
            Idioma.Japanese => new string[,]
            {
                { "手を持っているが拍手できないものは何ですか？",              "時計",           "時間を教えてくれます"          },
                { "乾かすほど濡れるものは何ですか？",                         "タオル",         "シャワーの後に使います"        },
                { "名前を言うと壊れるものは何ですか？",                       "沈黙",           "図書館にあります"              },
                { "前には進むが後ろには戻らないものは何ですか？",              "時間",           "取り戻せません"               },
                { "取るほど大きくなるものは何ですか？",                       "穴",             "地面に掘ります"               },
                { "3個のリンゴから2個取ったら何個持っていますか？",           "2",              "あなたが取りました..."         },
                { "あなたのものだが他の人の方が多く使うものは何ですか？",      "名前",           "生まれたときにつけられました"  },
                { "C#で親のメソッドを再定義するキーワードは何ですか？",       "override",       "戻り値の型の前に書きます"      },
                { "直接インスタンス化できないOOPクラスは何ですか？",          "abstract",       "'abstract'で宣言します"        },
                { "三角形と四角形の辺の数を合わせると？",                     "7",              "3 + 4"                        },
            },
            Idioma.Korean => new string[,]
            {
                { "손이 있지만 박수를 칠 수 없는 것은?",                    "시계",       "시간을 알려줍니다"             },
                { "닦을수록 더 젖는 것은?",                                  "수건",       "샤워 후에 사용합니다"          },
                { "이름을 말하면 깨지는 것은?",                              "침묵",       "도서관에 있습니다"             },
                { "앞으로만 가고 뒤로 가지 않는 것은?",                      "시간",       "되찾을 수 없습니다"            },
                { "꺼낼수록 커지는 것은?",                                   "구멍",       "땅에 파세요"                   },
                { "3개의 사과에서 2개를 가져가면 몇 개를 갖고 있나요?",      "2",          "당신이 가져갔습니다..."        },
                { "당신 것이지만 다른 사람이 더 많이 쓰는 것은?",            "이름",       "태어날 때 주어집니다"          },
                { "C#에서 부모 메서드를 재정의하는 키워드는?",               "override",   "반환 타입 앞에 옵니다"         },
                { "직접 인스턴스화할 수 없는 OOP 클래스는?",                 "abstract",   "'abstract'로 선언됩니다"        },
                { "삼각형과 사각형의 변을 합치면?",                          "7",          "3 + 4"                         },
            },
            Idioma.Chinese => new string[,]
            {
                { "什么东西有手但不能鼓掌？",               "时钟",   "它告诉你时间"           },
                { "越擦越湿的是什么？",                     "毛巾",   "洗澡后使用"             },
                { "说出名字就会破碎的是什么？",             "沉默",   "在图书馆里有"           },
                { "只会前进不会后退的是什么？",             "时间",   "无法找回"               },
                { "拿走越多变得越大的是什么？",             "洞",     "在地上挖"               },
                { "从3个苹果中拿走2个，你有几个？",         "2",      "是你拿走的..."          },
                { "属于你但别人用得更多的是什么？",         "名字",   "出生时被给予"           },
                { "C#中重新定义父方法的关键字是什么？",     "override","写在返回类型前面"      },
                { "不能直接实例化的OOP类是什么？",          "abstract","用'abstract'声明"       },
                { "三角形和正方形的边数加起来是多少？",     "7",      "3 + 4"                  },
            },
            _ => new string[,]
            {
                { "¿Qué tiene manos pero no puede aplaudir?",          "reloj",     "Te dice la hora"              },
                { "Mientras más secas, más moja. ¿Qué es?",           "toalla",    "La usas al salir del baño"    },
                { "¿Qué se rompe cuando lo nombras?",                  "silencio",  "Está en una biblioteca"       },
                { "¿Qué avanza pero nunca retrocede?",                 "tiempo",    "No puedes recuperarlo"        },
                { "Cuanto más quitas, más grande se hace. ¿Qué es?",  "hueco",     "Cávalo en la tierra"          },
                { "Si tomas 2 manzanas de 3, ¿cuántas tienes?",       "2",         "Tú tomaste..."                },
                { "¿Qué le pertenece pero otros lo usan más que tú?", "nombre",    "Te lo pusieron al nacer"      },
                { "En C#, ¿qué palabra redefine un método del padre?", "override",  "Va antes del tipo de retorno" },
                { "¿Qué clase de POO no puede instanciarse directo?",  "abstracta", "Se declara con 'abstract'"    },
                { "¿Cuántos lados suman un triángulo y un cuadrado?",  "7",         "3 + 4"                        },
            }
        };
    }
}
