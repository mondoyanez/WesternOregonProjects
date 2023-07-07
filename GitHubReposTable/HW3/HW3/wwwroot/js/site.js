
$(function() {
    $.ajax({
        type: "GET",
        dataType: "json",
        url: "/api/user",
        success: populateGitHubUserData,
        error: errorOnAjax
    });
});

$(function() {
    $.ajax({
        type: "GET",
        dataType: "json",
        url: "/api/repositories",
        success: populateGitHubRepoData,
        error: errorOnAjax
    });
});

function errorOnAjax() {
    console.log("ERROR in ajax request");
}

function populateGitHubUserData(data) {
    $("#github-user-image").attr("src", data["avatarURL"]);
    $("#github-user-info").append(`<h1 id="name-header"> ${data["name"]} </h1>`);
    $("#github-user-info").append(`<p id="github-account-info"> ${data["userName"]}`);
    $("#github-user-info").append(`<p id="github-account-info"> ${data["email"]}`);
    $("#github-user-info").append(`<p id="github-account-info"> ${data["company"]}`);
    $("#github-user-info").append(`<p id="github-account-info"> ${data["location"]}`);
}

function populateGitHubRepoData(data) {

    for (let i = 0; i < data.length; ++i) {
        let repoTR =
            `<tr>
                <td><input type="button" value=${data[i]["fullName"]} id="${data[i]["name"]}"/></td>
            </tr>`;
        $("#repository-names").append((repoTR));
        $("#repository-names").show();
    }

    //https://stackoverflow.com/questions/4781739/how-to-apply-add-event-listener-on-newly-created-element
    for (let i = 0; i < data.length; ++i) {
        document.addEventListener('click', function (event) {
            if (event.target.id === data[i]["name"]) {
                $("#commits-info").empty();
                $("#repository-info").empty();

                $("#commits-info").show();
                $("#commits-header").show();

                let params = `?owner=${data[i]["owner"]}&repo=${data[i]["name"]}`;
                let address = "/api/repository" + params;

                //https://stackoverflow.com/questions/31445242/ajax-request-response-order
                $.ajax({
                    type: "GET",
                    dataType: "json",
                    url: address,
                    success: displayRepoInfo,
                    error: errorOnAjax,
                    async: false
                });

                address = "/api/branches" + params;

                $.ajax({
                    type: "GET",
                    dataType: "json",
                    url: address,
                    success: displayBranchInfo,
                    error: errorOnAjax
                });

                address = "/api/commits" + params;

                $.ajax({
                    type: "GET",
                    dataType: "json",
                    url: address,
                    success: displayCommitInfo,
                    error: errorOnAjax
                });
            }
        });
    }
}

function displayRepoInfo(data) {

    $("#repository-info").append(`<h4><a href="${data["htmlURL"]}" target="_blank" id="repository-header"">${data["fullName"]}</a></h4>`);
    $("#repository-info").append("<br><br>");
    $("#repository-info").append(`<p class="github-data">Owner: ${data["owner"]}</p>`);
    $("#repository-info").append(`<p class="github-data">Last Updated: ${data["lastUpdated"]} day(s) agos</p>`);

    $("#github-repo-image").attr("src", data["ownerAvatarURL"]);
    $("#github-repo-image").show();
    $("#repository-container").show();
}

function displayBranchInfo(data) {

    $("#repository-info").append(`<p class="github-data">Branches:</p>`);

    for (let i = 0; i < data.length; ++i) {
        $("#repository-info").append(`<p class="branch-names github-data">${data[i]["name"]}</p>`);
    }
    
}

function displayCommitInfo(data) {

    let commitTR =
        `<tr>
            <th class="commits-data">SHA</th>
            <th class="commits-data">Timestamp</th>
            <th class="commits-data">Committer</th>
            <th class="commits-data">Commit Message</th>
        </tr>`;
    $("#commits-info").append(commitTR);

    for (let i = 0; data.length; ++i) {
        commitTR =
            `<tr>
                <td class="commits-data"><a href="${data[i]["htmlURL"]}" target="_blank" class="commit-link">${data[i]["sha"].substring(0, 8)}</a></td>
                <td class="commits-data">${data[i]["whenCommited"]}</td>
                <td class="commits-data">${data[i]["commiter"]}</td>
                <td class="commits-data">${data[i]["commitMessage"]}</td>
            </tr>`;
        $("#commits-info").append(commitTR);
    }
}