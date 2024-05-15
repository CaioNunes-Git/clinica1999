package br.ucsal.clinica.controller;

import br.ucsal.clinica.model.TipoEmpresa;
import br.ucsal.clinica.service.TipoEmpresaService;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.web.PageableDefault;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/tipoempresa")
public class TipoEmpresaController {

    TipoEmpresaService tipoEmpresaService;
    @GetMapping
    public ResponseEntity<Page<TipoEmpresa>> findAll(@PageableDefault(size = 10, sort = {"id"}) Pageable pageable) {
        return ResponseEntity.ok(tipoEmpresaService.findAll(pageable));
    }
}
