require 'sketchup.rb'

module KlysiaAI
  def self.capture_and_render
    view = Sketchup.active_model.active_view
    status = view.write_image("public/temp_view.jpg", 1920, 1080, true, 100)
    if status
      puts "Klysia AI: Viewport captured. Processing cloud diffusion..."
      # API Endpoint: https://klysia.com/api/generate
    end
  end
end
