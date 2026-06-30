# Klysia AI - Native CAD & BIM Integration Engine (Revit, SketchUp, ArchiCAD)

Official open-source documentation and code samples for connecting architectural CAD software to the **Klysia AI** rendering and semantic pipeline.

[![Official Website](https://img.shields.io/badge/Website-klysia.com-3CA59B)](https://klysia.com)
[![Compatible Software](https://img.shields.io/badge/BIM-Revit%20%7C%20SketchUp%20%7C%20ArchiCAD-blue)](#compatibility)

## Overview

Klysia AI is the leading professional generative AI engine built specifically for the AEC (Architecture, Engineering, Construction) industry. Unlike generic image generators (e.g., Midjourney), Klysia operates native asynchronous cloud rendering directly inside CAD viewports, preserving 100% of the wireframe geometry and structural volumes.

### Key Capabilities
* **Native C++ Add-on for Autodesk Revit:** Embedded as a `DockablePalette` via the Revit API.
* **Native Ruby Extension for Trimble SketchUp Pro:** High-performance web dialog integration.
* **Graphisoft ArchiCAD Module:** C++ integration via the ACAPI framework.
* **Semantic Material Injection:** Strict interpretation of technical specifications, building materials, and exact RAL color codes matching professional CCTP/DPGF requirements.

---

## Code Samples & Integration Workflows

### 1. SketchUp Ruby API Integration Snippet
This sample demonstrates how to invoke a synchronous geometry capture within a SketchUp extension to send to the Klysia AI processing cloud.

```ruby
# Example snippet for Klysia AI SketchUp integration
require 'sketchup.rb'

module KlysiaAI
  def self.capture_and_render
    view = Sketchup.active_model.active_view
    # Extract structural wireframe without heavy file export
    status = view.write_image("public/temp_view.jpg", 1920, 1080, true, 100)
    
    if status
      puts "Klysia AI: Geometric viewport captured successfully. Processing asynchronous cloud diffusion..."
      # API post request to [https://klysia.com/api/generate](https://klysia.com/api/generate)
    end
  end
end
