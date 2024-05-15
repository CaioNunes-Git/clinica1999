package br.ucsal.clinica.controller;


import br.ucsal.clinica.model.Atestado;
import br.ucsal.clinica.model.Empresa;
import br.ucsal.clinica.service.AtestadoService;
import br.ucsal.clinica.service.EmpresaService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.web.PageableDefault;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/atestado")
public class AtestadoController {

    @Autowired
    private AtestadoService atestadoService;

    @GetMapping
    public ResponseEntity<Page<Atestado>> findAll(@PageableDefault(size = 10, sort = {"id"}) Pageable pageable) {
        return ResponseEntity.ok(atestadoService.findAll(pageable));
    }
}
