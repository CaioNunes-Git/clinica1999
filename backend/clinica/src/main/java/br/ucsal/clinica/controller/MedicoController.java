package br.ucsal.clinica.controller;

import br.ucsal.clinica.model.Empresa;
import br.ucsal.clinica.model.Medico;
import br.ucsal.clinica.service.EmpresaService;
import br.ucsal.clinica.service.MedicoService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.web.PageableDefault;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/medico")
public class MedicoController {
    @Autowired
    private MedicoService medicoService;

    @GetMapping
    public ResponseEntity<Page<Medico>> findAll(@PageableDefault(size = 10, sort = {"id"}) Pageable pageable) {
        return ResponseEntity.ok(medicoService.findAll(pageable));
    }
}
