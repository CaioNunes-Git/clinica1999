package br.ucsal.clinica.model;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.relational.core.mapping.Table;

import java.util.List;

@Entity
@Table("empresa")
@AllArgsConstructor
@NoArgsConstructor
@Data
public class Empresa {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String cnpj;
    private String nomeFantasia;

    @OneToMany
    @Column(name = "tipo_empresa_id")
    private List<TipoEmpresa> tipoEmpresa;
}
