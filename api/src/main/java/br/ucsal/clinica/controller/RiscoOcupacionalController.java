package br.ucsal.clinica.controller;

import br.ucsal.clinica.model.RiscoOcupacional;
import br.ucsal.clinica.service.RiscoOcupacionalService;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.web.PageableDefault;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;


@RestController
@RequestMapping("/riscoocupacional")
public class RiscoOcupacionalController {

    RiscoOcupacionalService riscoOcupacionalService;

    @GetMapping
    public ResponseEntity<Page<RiscoOcupacional>> findAll(@PageableDefault(size = 10, sort = {"id"}) Pageable pageable) {
        return ResponseEntity.ok(riscoOcupacionalService.findAll(pageable));
    }
}
