$("#btnGrades").click(function () {
    let assign = $("#numAssign").val()
    let quiz = $("#numQuiz").val()
    let group = $("#numGroup").val()
    let intex = $("#numIntex").val()
    let exam = $("#numExam").val()

    assign = parseFloat(assign) * .5376
    quiz = parseFloat(quiz) * .0860
    group = parseFloat(group) * .0538
    intex = parseFloat(intex) * .1075
    exam = parseFloat(exam) * .2151

    total = assign + quiz + group + intex + exam
    total = Math.round(total, 2)
    let letter = ""

    if (total >= 94) {
        letter = "A"
    }
    else if (total >= 90) {
        letter = "A-"
    }
    else if (total >= 87) {
        letter = "B+"
    }
    else if (total >= 84) {
        letter = "B"
    }
    else if (total >= 80) {
        letter = "B-"
    }
    else if (total >= 77) {
        letter = "C+"
    }
    else if (total >= 74) {
        letter = "C"
    }
    else if (total >= 70) {
        letter = "C-"
    }
    else if (total >= 67) {
        letter = "D+"
    }
    else if (total >= 64) {
        letter = "D"
    }
    else if (total >= 60) {
        letter = "D-"
    }
    else {
        letter = "E"
    }

    $("#output").html("<b>Grade Total: " + total + " " + letter + "<b>")

})