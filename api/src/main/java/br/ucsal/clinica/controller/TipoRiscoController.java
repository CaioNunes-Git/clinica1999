package br.ucsal.clinica.controller;

import br.ucsal.clinica.model.TipoRisco;
import br.ucsal.clinica.service.TipoRiscoService;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.web.PageableDefault;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/tiporisco")
public class TipoRiscoController {

    TipoRiscoService tipoRiscoService;
    @GetMapping
    public ResponseEntity<Page<TipoRisco>> findAll(@PageableDefault(size = 10, sort = {"id"}) Pageable pageable) {
        return ResponseEntity.ok(tipoRiscoService.findAll(pageable));
    }
}
