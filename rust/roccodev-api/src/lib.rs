extern crate curl;
extern crate serde_json;

mod http;
pub mod monthlies;
pub mod winstreaks;
pub mod winstreaks_historical;

pub type Leaderboard = serde_json::Value;
pub type Profile = serde_json::Value;