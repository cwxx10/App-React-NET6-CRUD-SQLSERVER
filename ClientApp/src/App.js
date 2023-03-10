import { useEffect, useState } from "react";
import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import ReactDOM from 'react-dom';

const App = () => {

    //criar state
    const [produtos, setProdutos] = useState([])

    //criar useeffect
    useEffect(() => {
        fetch("api/produto/GetProdutos")
            .then(response => { return response.json() })
            .then(responseJson => {
                setProdutos(responseJson)
            })
        
    }, [])

    const items = [
        { id: 1, name: 'Item 1' },
        { id: 2, name: 'Item 2' },
        { id: 3, name: 'Item 3' }
    ];


    //criar tabela
    return (
        <div className="container">
            <h1>Produtos</h1>
            <div className="row">
                <div className="col-sm-12">
                    <table className="table table-striped">
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Codigo</th>
                                <th>Marca</th>
                                <th>Descricao</th>
                                <th>idCategoria</th>
                                <th>Estoque</th>
                                <th>Preço</th>
                                <th>Ativo?</th>
                                <th>Data da Venda</th>
                            </tr>
                        </thead>

                        <tbody>
                            {produtos.map((item) => (
                                <tr>
                                    <td>{item.idProduto}</td>
                                    <td>{item.codigo}</td>
                                    <td>{item.marca}</td>
                                    <td>{item.descricao}</td>
                                    <td>{item.idCategoria}</td>
                                    <td>{item.estoque}</td>
                                    <td>{item.preco}</td>
                                    <td>{item.isAtivo}</td>
                                    <td>{item.fecharRegistro}</td>
                                </tr>
                            ))}









                        </tbody>
                    </table>
                </div>
            </div>

        </div>)

}

export default App;

/*ReactDOM.render(<App />, document.getElementById('root'));*/