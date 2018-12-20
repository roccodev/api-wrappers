use super::curl::easy::Easy;

pub fn json_from_url(url: String) -> serde_json::Value {
    
    let mut curl = Easy::new();
    let mut json = Vec::new();
    curl.url(url.as_str()).unwrap();

    {
        let mut transfer_func = curl.transfer();
        transfer_func.write_function(|data| {
            json.extend_from_slice(data); 
           return Ok(data.len());
        }).unwrap();

        transfer_func.perform().unwrap();
    }

    assert_eq!(200, curl.response_code().unwrap()); // Make sure the server responded with 200

    return serde_json::from_slice(&json).unwrap();
}
