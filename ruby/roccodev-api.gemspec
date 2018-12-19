Gem::Specification.new do |s|
  s.name = "roccodev-api"
  s.version = "1.0.0"
  s.date = %q{2018-12-19}
  s.authors = "RoccoDev"
  s.summary = "Ruby wrapper for RoccoDev's API"
  s.files = Dir['**/*'].keep_if { |file| File.file?(file) }
  s.require_paths = ["lib"]
end
