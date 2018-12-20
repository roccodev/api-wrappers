use super::http;

pub fn leaderboard(mode: &String, start: Option<usize>, end: Option<usize>) -> serde_json::Value {

    let url;
    match start {
        None => url = format!("https://api.roccodev.pw/{}/monthlies/leaderboard/", mode),
        Some(ref start) => url = format!("https://api.roccodev.pw/{}/monthlies/leaderboard?from={}&to={}", mode, start, end.unwrap_or(500)),
    }
    let json = http::json_from_url(url);
    return json;
        
}

pub fn profile(mode: &String, uuid: &String) -> serde_json::Value {
    let url = format!("https://api.roccodev.pw/{}/monthlies/profile/{}", mode, uuid);
    let json = http::json_from_url(url);
    return json; 
}

